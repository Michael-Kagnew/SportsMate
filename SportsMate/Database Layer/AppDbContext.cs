using Microsoft.EntityFrameworkCore;
using SportsMate.Business_Layer.Business_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsMate.Database_Layer
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected DbSet<AdminAccount> AdminAccounts { get; set; }
        public DbSet<CustomerAccount> CustomerAccounts { get; set; }

    }
}
