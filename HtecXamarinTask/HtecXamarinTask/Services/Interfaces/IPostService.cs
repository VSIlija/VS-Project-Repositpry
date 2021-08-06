using HtecXamarinTask.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HtecXamarinTask.Services.Interfaces
{
    public interface IPostService
    {
        /// <summary>
        /// Get all Posts depends on cache validity, from API or Localy.
        /// </summary>
        /// <returns></returns>
        Task<List<PostModel>> GetAllAsync();

        /// <summary>
        /// Refresh new Posts from API.
        /// </summary>
        /// <returns></returns>
        Task<List<PostModel>> ReloadAsync();

        /// <summary>
        /// Delete Post localy.
        /// </summary>
        /// <param name="post"></param>
        /// <returns></returns>
        Task DeleteAsync(PostModel post);
    }
}
