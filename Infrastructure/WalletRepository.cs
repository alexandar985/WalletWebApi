using System;
using System.Data.Entity;
using System.Threading.Tasks;
using WalletWebApi.Domain.Entities;
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
        public async Task<Wallet> Create(Wallet wallet)
        {
            _context.Wallet.Add(wallet);
            await _context.SaveChangesAsync();
            return wallet;
        }
        public async Task<Wallet> GetWalletByIdAsync(Guid walletId, Guid userId)
        {
            var result = await _context.Wallet.FirstOrDefaultAsync(wallet => wallet.Id == walletId && wallet.UserId == userId);
            return result;
        }


    }

}