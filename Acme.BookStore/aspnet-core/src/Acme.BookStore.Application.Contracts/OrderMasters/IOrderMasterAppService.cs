using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.BookStore.OrderMasters
{
    public interface IOrderMasterAppService : ICrudAppService<OrderMasterDto, Guid, PagedAndSortedResultRequestDto,CreateUpdateOrderMasterDto>
    {
        //Task<ListResultDto<CustomerLookupDto>> GetCustomerLookupAsync();
        ////Task<ExtensiblePagedResultDto<OrderMasterDto>> GetListAsync(ExtensiblePagedAndSortedResultRequestDto input);
        //Task<ListResultDto<OrderDetailLookupDto>> GetOrderDetailLookupAsync();
        //Task DeleteAsync(Guid id, OrderMasterDto input);
    }
}
