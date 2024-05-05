using Institute.Dao.DbContextF;
using Institute.Common.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Institute.Common.Repositories;

namespace Institute.Dao.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        public InstituteDbContext _dbContext;
        public AccountRepository(InstituteDbContext dbContext) 
        {  
            _dbContext = dbContext; 
        }
        public async Task<LoginDetails> GetLoginDetails(string username, string password)
        {
            var dbRecord = await _dbContext.TblLoginDetails.Where(p=> 
            (p.UserName !=null && p.UserName.Equals(username)) &&
            (p.Password !=null && p.Password.Equals(password))).FirstOrDefaultAsync();
            return dbRecord!;
        }
    }
}
