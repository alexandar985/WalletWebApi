using System;
using System.Threading.Tasks;
using WalletWebApi.Domain.Entities;
using WalletWebApi.Dtos;

namespace WalletWebApi.Interfaces
{
    public interface IWalletService
    {

        Task<WalletDto> GetWalletAsync(Guid walletId, Guid userId);
        Task<WalletDto> CreateAsync(WalletDto walletDto);
        Task<WalletEvent> AddFundsAsync(AddFundsDto addFundsDto);
        Task<WalletEvent> WithdrawFundsAsync(WithdrawFundsDto withdrawFundsDto);
    }
}
