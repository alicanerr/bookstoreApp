using Acme.BookStore.Permissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.OrderDetails
{
    public class OrderDetailAppService : CrudAppService<OrderDetail, OrderDetailDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateOrderDetailDto>, IOrderDetailAppService
    {
        public OrderDetailAppService(IRepository<OrderDetail, Guid> repository) : base(repository)
        {
            GetPolicyName = BookStorePermissions.OrderDetails.Default;
            GetListPolicyName = BookStorePermissions.OrderDetails.Default;
            CreatePolicyName = BookStorePermissions.OrderDetails.Create;
            UpdatePolicyName = BookStorePermissions.OrderDetails.Edit;
            DeletePolicyName = BookStorePermissions.OrderDetails.Delete;
        }
    }
}
