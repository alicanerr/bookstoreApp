using Acme.BookStore.Customers;
using Acme.BookStore.OrderDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.OrderMasters
{
    public class OrderMaster : AuditedAggregateRoot<Guid>
    {
        public Guid CustomerId { get; set; }
        //public Customer Customer { get; set; }

        public DateTime SiparisTarihi { get; set; }
        public string SevkAdres { get; set; }

        public Guid OrderDetailId { get; set; }
        //public OrderDetail OrderDetail { get; set; }
        public bool OnayBilgisi { get; set; }
    }
}
