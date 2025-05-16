using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WalletWebApi.Domain.Entities;

namespace WalletWebApi.Infrastructure
{
    public class WalletDbContext : DbContext
    {
        public WalletDbContext() : base("name=DefaultConnection")
        {
        }

        public DbSet<Wallet> Wallet { get; set; }
        public DbSet<WalletEvent> WalletEvents { get; set; }
    }    
}