using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace WalletWebApi.Controllers
{
    [RoutePrefix("api/wallet")]
    public class WalletController : ApiController
    {
        [HttpPost]
        [Route("create")]
        public async Task<IHttpActionResult> CreateWallet()
        {

            return Ok();
        }

        [HttpPost]
        [Route("add")]
        public async Task<IHttpActionResult> AddFunds()
        {

            return Ok();
        }

        [HttpPost]
        [Route("Withdraw")]
        public async Task<IHttpActionResult> WithdrawFunds()
        {
            return Ok();
        }

        [HttpGet]
        [Route("getwallet")]
        public async Task<IHttpActionResult> Get()
        {
            return Ok();
        }
    }
}
