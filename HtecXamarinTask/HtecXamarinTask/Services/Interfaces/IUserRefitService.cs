using HtecXamarinTask.DTOs;
using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HtecXamarinTask.Services.Interfaces
{
    public interface IUserRefitService
    {
        /// <summary>
        /// Get user by id from API
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Get("/users")]
        Task<List<UserDto>> GetById(int id);
    }
}
