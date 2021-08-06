using HtecXamarinTask.DTOs;
using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HtecXamarinTask.Services.Interfaces
{
    public interface IPostRefitService
    {
        /// <summary>
        /// Get all posts from API.
        /// </summary>
        /// <returns></returns>
        [Get("/posts")]
        Task<List<PostDto>> GetAll();
    }
}
