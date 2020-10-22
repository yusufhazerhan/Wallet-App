using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WalletApp.Models
{
    public class Context:DbContext
    {
        //SqlServer connection
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=HAZERHAN\\SQLEXPRESS; " +
                "database=DBWallet; " +
                "integrated security=true;");
        }
        public DbSet<Transaction> transactions { get; set; }
    }
}
