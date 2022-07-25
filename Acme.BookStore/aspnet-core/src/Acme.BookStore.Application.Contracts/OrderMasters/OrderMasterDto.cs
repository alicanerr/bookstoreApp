using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.BookStore.OrderMasters
{
    public class OrderMasterDto : AuditedEntityDto<Guid>
    {
        public Guid OrderDetailId { get; set; }
        public string StockName { get; set; }
        public Guid CustomerId { get; set; }
        public string CustomerName { get; set; }

        public DateTime SiparisTarihi { get; set; }
        public string SevkAdres { get; set; }
        public bool OnayBilgisi { get; set; }
    }
}
