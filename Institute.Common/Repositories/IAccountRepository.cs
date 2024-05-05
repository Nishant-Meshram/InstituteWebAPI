using Institute.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Institute.Common.Repositories
{
    public interface IAccountRepository
    {
        Task<LoginDetails> GetLoginDetails(string username,  string password);
    }
}
