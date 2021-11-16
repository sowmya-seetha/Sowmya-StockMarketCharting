using Microsoft.EntityFrameworkCore;
using StockMarket.Admin.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarket.Account.Entities
{
    public class StockMarketDbContext:DbContext
    {
    //    public DbSet<AdminLogin> AdminLogins { get; set; }

        public DbSet<Company> companies { get; set; }
        public DbSet<StockExchange> stockexchanges { get; set; }

     //   public DbSet<Signup> Signups { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-RD5JL9H\SQLEXPRESS;Initial Catalog=StockMarketDb;Integrated Security=True");
        }

    }
}
