using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheropodSystem.Models.Auth;

namespace TheropodSystem.Services
{
    public class UserService
    {
        List<User> users;

        public UserService()
        {
            users = new List<User>();
        }

        public AuthResult Login(string login, string password)
        {
            User? user = FindUser(login);
            if (user == null)
                return new AuthError("User Not Found");

            if (user.Password != password)
                return new AuthError("Wrong Password");

            return new AuthSuccess("Success", user);
        }

        public User? FindUser(string login)
        {
            return users.FirstOrDefault(user => user.Login == login);
        }
    }
}