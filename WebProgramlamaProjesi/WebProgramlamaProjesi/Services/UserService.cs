using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Services
{
    public interface IUserService
    {
        IdentityUser Authenticate(string userName, string password);
        List<IdentityUser> GetAll();
    }
    public class UserService : IUserService
    {
        private List<IdentityUser> _users = new List<IdentityUser>
        {
            new IdentityUser { Id = "1681a02b-866a-49f0-9539-3a189255336f", UserName = "kutay@gmail.com", PasswordHash = "AQAAAAEAACcQAAAAEHgc1xO6XfGT+FQ7VXONCo3rj8Yb7k/UYfY/gs4KW8mclJs5vHKgpNHZSjrggdxbMw==" }
        };
        public IdentityUser Authenticate(string userName, string password)
        {
            var user = _users.FirstOrDefault(x => x.UserName == userName && x.PasswordHash == password.GetHashCode().ToString());

            return user;
        }

        public List<IdentityUser> GetAll()
        {
            return _users;
        }
    }
}
