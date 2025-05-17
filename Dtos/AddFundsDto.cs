using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WalletWebApi.Dtos
{
    public class AddFundsDto
    {
        [Required(ErrorMessage = "Wallet Id is requred.")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "User Id is requred.")]
        public Guid UserId { get; set; }

        [ConcurrencyCheck]
        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Balance must be a positive number.")]

        public decimal Amount { get; set; } = 0m;

        [Required]
        public int Description { get; set; }
    }
}