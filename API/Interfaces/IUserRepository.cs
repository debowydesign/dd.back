using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;

namespace API.Interfaces
{
    public interface IUserRepository
    {
        void Update(User user);
    
        Task<bool> SaveAllAsync();

        Task<User> GetUserByUsernameAsync(string username);

        Task<User> GetUserOnlyTestAsync(Guid id);

    }
}