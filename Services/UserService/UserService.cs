using Entities;
using Entities.Response;
using Repository;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.Extensions.Configuration;
using Services.MailService;
using System.Security.Claims;

namespace Services.UserService
{
    public class UserService : IUserService
    {
        private readonly IBaseRepository<User> _repository;
        private readonly IBaseRepository<UserPassword> _repositoryPassword;
        private readonly IConfiguration _configuration;
        private readonly IEmailSender _emailSender;

        public UserService(IBaseRepository<User> repository,
            IBaseRepository<UserPassword> repositoryPassword,
            IConfiguration configuration,
            IEmailSender emailSender)
        {
            _repository = repository;
            _repositoryPassword = repositoryPassword;
            _configuration = configuration;
            _emailSender = emailSender;
        }

        #region Private Helper Method
        private string HashString(string text)
        {
            string salt = "akjlkjdaljlkdjalkjdsadlkaskl";
            if (string.IsNullOrEmpty(text))
            {
                return string.Empty;
            }

            // Uses SHA256 to create the hash
            using (var sha = new System.Security.Cryptography.SHA256Managed())
            {
                // Convert the string to a byte array first, to be processed
                byte[] textBytes = System.Text.Encoding.UTF8.GetBytes(text + salt);
                byte[] hashBytes = sha.ComputeHash(textBytes);

                // Convert back to a string, removing the '-' that BitConverter adds
                string hash = BitConverter
                    .ToString(hashBytes)
                    .Replace("-", string.Empty);

                return hash;
            }
        }
        #endregion



        public async Task<ResponseObject<User>> Login(string username, string password)
        {
            try
            {
                string[] includes = { "UserRole"};
                var users = await _repository.Where(a => a.UserName == username, includes);
                if (users != null && users.Count>0)
                {
                    var user = users.FirstOrDefault();
                    var passwordInfo = await _repositoryPassword.Where(a => a.HashPassword == HashString(password));
                    if(passwordInfo !=null && passwordInfo.Count > 0)
                    {
                        var data = passwordInfo.FirstOrDefault();
                        if (data.IsCurrent)
                            return new ResponseObject<User>(user, message: "User successfully retrieved");
                    }
                }

                return new ResponseObject<User>(null, message: "User not exist");
            }
            catch (Exception ex)
            {
                return new ResponseObject<User>(ex);
            }
        }
        public async Task<ResponseObject<bool>> AddUser(User user)
        {
            try
            {
                user.UserRoleId = new Guid("567B8222-BD08-4D84-95CE-3369C9AB0CF6");
                var done = await _repository.Insert(user);
                if (done)
                {
                    var password = new UserPassword();
                    password.IsCurrent = true;
                    password.UserId = user.Id;
                    password.HashPassword = HashString(user.Password);

                    await _repositoryPassword.Insert(password);
                }
                return new ResponseObject<bool>(true, message: "User added sussefully");
            }
            catch (Exception ex)
            {
                return new ResponseObject<bool>(ex);
            }
        }
        public async Task<ResponseObject<bool>> DeleteUser(Guid userId)
        {
            try
            {
                var user = await _repository.GetById(userId);
                if (user != null)
                {
                    _repository.Delete(user);
                    return new ResponseObject<bool>(true, message: "User successfully deleted");
                }
                return new ResponseObject<bool>(false, message: "User not exist");
            }
            catch (Exception ex)
            {
                return new ResponseObject<bool>(ex);
            }
        }
        public async Task<ResponseObject<User>> GetUser(Guid userId)
        {
            try
            {
                var user = await _repository.GetById(userId);
                if (user != null)
                    return new ResponseObject<User>(user, message: "User successfully deleted");

                return new ResponseObject<User>(null, message: "User not exist");
            }
            catch (Exception ex)
            {
                return new ResponseObject<User>(ex);
            }
        }
        public async Task<ResponseObject<List<User>>> GetUsers()
        {
            try
            {
                var users = await _repository.GetAll();
                if (users != null && users.Count > 0)
                    return new ResponseObject<List<User>>(users, message: "User successfully deleted");

                return new ResponseObject<List<User>>(null, message: "User not exist");
            }
            catch (Exception ex)
            {
                return new ResponseObject<List<User>>(ex);
            }
        }
        public async Task<ResponseObject<bool>> UpdateUser(User user)
        {
            try
            {
                _repository.Update(user);
                return new ResponseObject<bool>(true, message: "User updated successfully");
            }
            catch (Exception ex)
            {
                return new ResponseObject<bool>(ex);
            }
        }
    }
}
