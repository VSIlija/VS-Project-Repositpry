using HtecXamarinTask.DTOs;
using HtecXamarinTask.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HtecXamarinTask.Services
{
    public class UserRefitService : IUserRefitService
    {
        /// <inheritdoc/>
        public Task<List<UserDto>> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
