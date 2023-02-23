using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheropodSystem.Models.Auth
{
    public class AuthSuccess : AuthResult
    {
        public AuthSuccess(string message, User user) : base(message)
        {
            base.Success = true;
            base.User = user;
        }
    }
}