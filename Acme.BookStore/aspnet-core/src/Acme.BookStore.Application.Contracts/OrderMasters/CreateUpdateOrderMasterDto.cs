using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Acme.BookStore.OrderMasters
{
    public class CreateUpdateOrderMasterDto
    {
        [Required]
        public Guid OrderDetailId { get; set; }
        [Required]
        public Guid CustomerId { get; set; }
        [Required]
        public DateTime SiparisTarihi { get; set; }
        [Required]
        public string SevkAdres { get; set; }
        [Required]
        public bool OnayBilgisi { get; set; }
    }
}
