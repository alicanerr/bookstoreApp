using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Customers
{
    public interface ICustomerRepository : IRepository<Customer, Guid>
    {
        Task<Customer> FindByNameAsync(string name);
        Task<List<Customer>> GetListAsync();
    }
}
