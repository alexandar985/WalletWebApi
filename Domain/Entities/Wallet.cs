using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WalletWebApi.Domain.Entities
{
    public class Wallet
    {
        [Key]
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        [ConcurrencyCheck]
        public decimal Balance { get; set; }

        public DateTime CreatedAtUTC { get; set; }

        public List<WalletEvent> WalletEvents { get; set; } = new List<WalletEvent>();
    }
}