using Acme.BookStore.OrderMasters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.OrderDetails
{
    public class OrderDetail : Entity<Guid>
    {
        
        //public OrderMaster OrderMaster { get; set; }
        public string StokAdi { get; set; }
        public int Miktar { get; set; }
        public decimal Tutar { get; set; }
        
    }
}
