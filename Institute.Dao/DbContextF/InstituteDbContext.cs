using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Institute.Common.Entities;
using Microsoft.EntityFrameworkCore;


namespace Institute.Dao.DbContextF
{
    public class InstituteDbContext : DbContext
    {
        public DbSet<User> TblUser { get; set; }
        public DbSet<LoginDetails> TblLoginDetails { get; set; }


        public InstituteDbContext(DbContextOptions<InstituteDbContext> options) : base(options) { } 

    }
}
