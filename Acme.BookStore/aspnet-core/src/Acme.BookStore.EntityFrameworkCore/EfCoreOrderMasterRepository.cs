//using Acme.BookStore.EntityFrameworkCore;
//using Acme.BookStore.OrderMasters;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
//using Volo.Abp.EntityFrameworkCore;

//namespace Acme.BookStore
//{
//    public class EfCoreOrderMasterRepository : EfCoreRepository<BookStoreDbContext, OrderMasters.OrderMaster, Guid>, IOrderMasterRepository

//    {
//        public EfCoreOrderMasterRepository(IDbContextProvider<BookStoreDbContext> dbContextProvider) : base(dbContextProvider)
//        {
//        }

//        public async Task<OrderMaster> FindByNameAsync(bool statusCode)
//        {
//            var dbSet = await GetDbSetAsync();
//                return await dbSet.FirstOrDefaultAsync(orderMaster=> orderMaster.OnayBilgisi == statusCode);
//        }
//    }
//}
