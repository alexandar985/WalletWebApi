using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using WalletWebApi.Dtos;
using WalletWebApi.Interfaces;

namespace WalletWebApi.Controllers
{
    [RoutePrefix("api/wallet")]
    public class WalletController : ApiController
    {
        private readonly IWalletService _walletService;

        public WalletController(IWalletService walletService)
        {
            _walletService = walletService;
        }

        [HttpPost]
        [Route("create")]
        public async Task<IHttpActionResult> CreateWallet(WalletDto walletDto)
        {
            if (walletDto == null)
            {
                return BadRequest();
            }

            await _walletService.CreateAsync(walletDto);

            return Ok();
        }

        [HttpPost]
        [Route("add")]
        public async Task<IHttpActionResult> AddFunds(AddFundsDto addFundsDto)
        {
            if (addFundsDto == null)
            {
                return BadRequest();
            }
            await  _walletService.AddFundsAsync(addFundsDto);

            return Ok();
        }

        [HttpPost]
        [Route("Withdraw")]
        public async Task<IHttpActionResult> WithdrawFunds(WithdrawFundsDto withdrawFundsDto)
        {
            if (withdrawFundsDto == null)
            {
                return BadRequest();
            }
            await _walletService.WithdrawFundsAsync(withdrawFundsDto);
            return Ok();
        }

        [HttpGet]
        [Route("getwallet/{userId}/id")]
        public async Task<IHttpActionResult> Get(Guid userId, Guid id)
        {
            var wallet=await _walletService.GetWalletAsync(id, userId);
            return Ok();
        }
    }
}
