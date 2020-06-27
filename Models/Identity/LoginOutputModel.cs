using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork.Models.Identity
{
    public class LoginOutputModel
    {
        public LoginOutputModel(string token, int dealerId)
        {
            this.Token = token;
            this.DealerId = dealerId;
        }

        public int DealerId { get; }

        public string Token { get; }
    }
}
