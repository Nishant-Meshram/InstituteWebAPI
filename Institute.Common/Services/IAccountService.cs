using Institute.Common.DTOs.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Institute.Common.Services
{
    public interface IAccountService
    {
        Task<LoginResponse> VerifyLoginDetails(LoginRequest request);
    }
}
