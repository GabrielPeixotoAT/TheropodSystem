using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheropodSystem.Models.Auth
{
    public class AuthError : AuthResult
    {
        public AuthError(string message) : base(message)
        {
            base.HasError = true;
        }
    }
}