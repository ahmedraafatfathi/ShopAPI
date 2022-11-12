using Entities;
using Entities.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.UserService
{
    public interface IUserService
    {
        Task<ResponseObject<User>> Login(string username, string password);
        Task<ResponseObject<bool>> AddUser(User user);
        Task<ResponseObject<bool>> UpdateUser(User user);
        Task<ResponseObject<bool>> DeleteUser(Guid userId);
        Task<ResponseObject<List<User>>> GetUsers();
        Task<ResponseObject<User>> GetUser(Guid userId);
    }
}
