using Acme.BookStore.Permissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Customers
{
    public class CustomerAppService :CrudAppService<Customer, CustomerDto,Guid, PagedAndSortedResultRequestDto,CreateUpdateCustomerDto>,ICustomerAppService
    {

        public CustomerAppService(IRepository<Customer, Guid> repository): base(repository)
        {
            GetPolicyName = BookStorePermissions.Customers.Default;
            GetListPolicyName = BookStorePermissions.Customers.Default;
            CreatePolicyName = BookStorePermissions.Customers.Create;
            UpdatePolicyName = BookStorePermissions.Customers.Edit;
            DeletePolicyName = BookStorePermissions.Customers.Delete;
        }


    }
}
