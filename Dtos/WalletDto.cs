using System;
using System.ComponentModel.DataAnnotations;

namespace WalletWebApi.Dtos
{
    public class WalletDto
    {
        [Required(ErrorMessage = "Wallet Id is requred.")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "User Id is requred.")]
        public Guid UserId { get; set; }

        [ConcurrencyCheck]
        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Balance must be a positive number.")]

        public decimal Balance { get; set; } = 0m;

        [Required]
        public int Description { get; set; }
    }
}