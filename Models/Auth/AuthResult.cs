using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheropodSystem.Models.Auth
{
    public class AuthResult
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public bool HasError { get; set; }
        public User? User { get; set; }

        public AuthResult(string message)
        {
            Message = message;
        }
    }
}