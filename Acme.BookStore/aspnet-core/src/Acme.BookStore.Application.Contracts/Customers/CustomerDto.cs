using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.BookStore.Customers
{
    public class CustomerDto :AuditedEntityDto<Guid>
    {
        public string MusteriAd { get; set; }
        public int RiskLimit { get; set; }
        public string FaturaAdres { get; set; }
    }
}
