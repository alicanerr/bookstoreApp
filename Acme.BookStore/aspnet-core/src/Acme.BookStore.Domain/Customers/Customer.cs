using Acme.BookStore.OrderMasters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.Customers
{
    public class Customer : Entity<Guid>
    {
        public string MusteriAd { get; set; }
        public int RiskLimit { get; set; }
        public string FaturaAdres { get; set; }
        //public ICollection<OrderMaster> OrderMaster { get; set; }
    }
}
