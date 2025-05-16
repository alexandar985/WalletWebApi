using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WalletWebApi.Domain.Enums;

namespace WalletWebApi.Domain.Entities
{
    public class WalletEvent
    {
        [Key]
        public Guid Id { get; set; }
        public Guid WalletId { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreatedAtUTC { get; set; }
        public WalletEventType Type { get; set; }  
        public FundDescription Description { get; set; } 
    }
}