using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.OrderMasters
{
    public interface IOrderMasterRepository : IRepository<OrderMaster, Guid>
    {
        Task<OrderMaster> FindByNameAsync(bool statusCode);
}
}
