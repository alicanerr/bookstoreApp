using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.BookStore.OrderDetails
{
    public interface IOrderDetailAppService : ICrudAppService<OrderDetailDto, Guid, PagedAndSortedResultRequestDto,CreateUpdateOrderDetailDto>
    {
    }
}
