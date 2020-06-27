using HomeWork.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork.Services.Identity
{
    public interface IJwtTokenGeneratorService
    {
        string GenerateToken(User user);
    }
}
