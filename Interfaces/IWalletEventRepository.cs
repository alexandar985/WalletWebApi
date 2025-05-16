using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using WalletWebApi.Domain.Entities;

namespace WalletWebApi.Interfaces
{
    public interface IWalletEventRepository
    {
        Task<WalletEvent> Add(WalletEvent walletEvent);
    }
}