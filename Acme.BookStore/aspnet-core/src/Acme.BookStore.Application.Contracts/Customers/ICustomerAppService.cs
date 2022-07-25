using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.BookStore.Customers
{
    public interface ICustomerAppService :ICrudAppService<CustomerDto,Guid, PagedAndSortedResultRequestDto,CreateUpdateCustomerDto>
    {
    }
}
