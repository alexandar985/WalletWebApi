using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WalletWebApi.Interfaces;

namespace WalletWebApi.Infrastructure
{
    public class WalletRepository : IWalletRepository
    {
        private readonly WalletDbContext _context;
        public WalletRepository(WalletDbContext context)
        {
            _context = context;
        }
        
    }
    
}