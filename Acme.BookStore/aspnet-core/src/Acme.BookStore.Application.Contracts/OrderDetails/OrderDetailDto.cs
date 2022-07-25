using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.BookStore.OrderDetails
{
    public class OrderDetailDto : AuditedEntityDto<Guid>
    {


        public string StokAdi { get; set; }
        
        public int Miktar { get; set; }
        
        public decimal Tutar { get; set; }

    }
}
