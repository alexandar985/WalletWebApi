using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WalletWebApi.Entities
{
    public class Wallet
    {
        [Key]
        public Guid Id { get; set; }

        [ConcurrencyCheck]
        public decimal Balance { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}