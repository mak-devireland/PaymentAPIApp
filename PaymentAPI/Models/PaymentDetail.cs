using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentAPI.Models
{
    public class PaymentDetail
    {
        [Key]
        public int PaymentId { get; set; }

        [Required]
        [StringLength(100)]
        public string CardHolder { get; set; }

        [Required]
        [StringLength(16, MinimumLength = 16)]
        public string CardNumber { get; set; }

        [Required]
        [StringLength(5, MinimumLength = 5)]
        public string ExpiringDate { get; set; }

        [Required]
        [StringLength(3, MinimumLength = 3)]
        public string SecurityCode { get; set; }
    }
}
