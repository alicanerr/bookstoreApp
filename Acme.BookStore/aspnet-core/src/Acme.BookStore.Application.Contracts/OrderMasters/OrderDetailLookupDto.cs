using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.BookStore.OrderMasters
{
    public class OrderDetailLookupDto : EntityDto<Guid>
    {
        public string StokAdi { get; set; }
    }
}
