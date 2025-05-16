using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using WalletWebApi.Domain.Entities;
using WalletWebApi.Interfaces;

namespace WalletWebApi.Infrastructure
{
    public class WalletEventRepository : IWalletEventRepository
    {
        private readonly WalletDbContext _context;
        public WalletEventRepository(WalletDbContext context)
        {
            _context = context;
        }

        public async Task<WalletEvent> Add(WalletEvent walletEvent)
        {
            _context.WalletEvents.Add(walletEvent);
            await _context.SaveChangesAsync();
            return walletEvent;
        }
    }
}