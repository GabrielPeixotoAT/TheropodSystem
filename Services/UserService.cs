using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheropodSystem.Models.Auth;
using Newtonsoft.Json;
using TheropodSystem;

namespace TheropodSystem.Services
{
    public class UserService
    {
        List<User> users;

        public UserService()
        {
            List<User>? users;

            using (StreamReader file = File.OpenText(SystemInfo.DATA_PATH+"/users.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                users = serializer.Deserialize(file, typeof(List<User>)) as List<User>;
            }
            if (users != null)
                this.users = users;
            else
                this.users = new List<User>();
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