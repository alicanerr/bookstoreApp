using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.BookStore.OrderMasters
{
    public class CustomerLookupDto : EntityDto<Guid>
    {
        public string MusteriAd { get; set; }
    }
}
