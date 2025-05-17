using System;
using System.Threading.Tasks;
using WalletWebApi.Domain.Entities;
using WalletWebApi.Dtos;
using WalletWebApi.Interfaces;

namespace WalletWebApi.Services
{
    public class WalletService : IWalletService
    {
        public Task<WalletEvent> AddFundsAsync(AddFundsDto addFundsDto)
        {
            throw new NotImplementedException();
        }

        public Task<WalletDto> CreateAsync(WalletDto walletDto)
        {
            throw new NotImplementedException();
        }

        public Task<WalletDto> GetWalletAsync(Guid walletId, Guid userId)
        {
            throw new NotImplementedException();
        }

        public Task<WalletEvent> WithdrawFundsAsync(WithdrawFundsDto withdrawFundsDto)
        {
            throw new NotImplementedException();
        }
    }
}