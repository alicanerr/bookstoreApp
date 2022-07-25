//using Acme.BookStore.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
//using Volo.Abp.EntityFrameworkCore;

//namespace Acme.BookStore.OrderMasters
//{
//    public class EfCoreCustomerRepository : EfCoreRepository<BookStoreDbContext, OrderMaster, Guid>, IOrderMasterRepository
//    {
//        public EfCoreCustomerRepository(IDbContextProvider<BookStoreDbContext> dbContextProvider) : base(dbContextProvider)
//        {
//        }

//        public Task<OrderMaster> FindByNameAsync(bool statusCode)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
