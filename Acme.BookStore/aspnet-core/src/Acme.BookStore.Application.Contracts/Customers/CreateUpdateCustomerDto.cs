using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Acme.BookStore.Customers
{
    public class CreateUpdateCustomerDto
    {
        [Required]
        public string MusteriAd { get; set; }
        [Required]
        public int RiskLimit { get; set; }
        [Required]
        public string FaturaAdres { get; set; }
    }
}
