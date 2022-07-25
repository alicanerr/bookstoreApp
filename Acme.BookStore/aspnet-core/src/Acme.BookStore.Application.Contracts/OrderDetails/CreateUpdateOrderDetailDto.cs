using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Acme.BookStore.OrderDetails
{
    public class CreateUpdateOrderDetailDto
    {

        [Required]
        public string StokAdi { get; set; }
        [Required]
        public int Miktar { get; set; }
        [Required]
        public decimal Tutar { get; set; }


    }
}
