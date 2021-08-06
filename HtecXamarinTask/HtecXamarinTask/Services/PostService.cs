using HtecXamarinTask.Constants;
using HtecXamarinTask.Models;
using HtecXamarinTask.Models.Cache;
using HtecXamarinTask.Services.Interfaces;
using MonkeyCache.SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HtecXamarinTask.Services
{
    public class PostService : IPostService
    {
        private readonly IPostRefitService _postRefitService;
        public PostService(IPostRefitService postRefitService)
        {
            _postRefitService = postRefitService;
        }

        /// <inheritdoc/>
        public async Task<List<PostModel>> GetAllAsync()
        {
            if (!Barrel.Current.IsExpired(Settings.CacheKeyes.Posts))
            {
                return Barrel.Current.Get<CachePostModel>(Settings.CacheKeyes.Posts).Posts;
            }

            return await FetchAndCacheAsync(); 
        }

        /// <inheritdoc/>
        public async Task<List<PostModel>> ReloadAsync() 
        {
            return await FetchAndCacheAsync();
        }

        /// <inheritdoc/>
        public async Task DeleteAsync(PostModel post)
        {
            var posts = await GetAllAsync();
            var postToDelete = posts.FirstOrDefault(x => x.Id == post.Id);
            if (postToDelete != null)
            {
                posts.Remove(postToDelete);
                Add(posts, CalculateRemaningTime());
            }
        }

        /// <summary>
        /// Add Posts in cache for a certain period of time
        /// </summary>
        /// <param name="posts"></param>
        /// <param name="timeSpan"></param>
        private void Add(List<PostModel> posts, TimeSpan? timeSpan = null)
        {
            var cachedData = new CachePostModel
            {
                Posts = posts,
                Date = DateTime.Now
            };

            var cacheDuration = timeSpan ?? Settings.CacheDurationMinutes;
            Barrel.Current.Add(Settings.CacheKeyes.Posts, cachedData, cacheDuration);
        }

        /// <summary>
        /// Fetch Posts from API and save them in cache
        /// </summary>
        /// <returns></returns>
        private async Task<List<PostModel>> FetchAndCacheAsync()
        {
            var posts = (await _postRefitService.GetAll()).Select(postDto => new PostModel(postDto)).ToList();
            Add(posts);

            return posts;
        }

        /// <summary>
        /// Calculate how much longer the cache is valid
        /// </summary>
        /// <returns></returns>
        private TimeSpan CalculateRemaningTime()
        {
            DateTime lastFetchedDataTime = Barrel.Current.Get<CachePostModel>(Settings.CacheKeyes.Posts).Date;
            return TimeSpan.FromSeconds(Settings.CacheDurationMinutes.TotalSeconds - (DateTime.Now - lastFetchedDataTime).TotalSeconds);
        }
    }
}

