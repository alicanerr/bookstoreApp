using Acme.BookStore.Customers;
using Acme.BookStore.OrderDetails;
using Acme.BookStore.Permissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.OrderMasters
{

    public class OrderMasterAppService : CrudAppService<OrderMaster, OrderMasterDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateOrderMasterDto>, IOrderMasterAppService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IRepository<OrderDetail, Guid> _orderdetailRepository;
        //private readonly IOrderMasterRepository _ordermasterRepository;

        public OrderMasterAppService(IRepository<OrderMaster, Guid> repository, IRepository<OrderDetail, Guid> orderdetailRepository, ICustomerRepository customerRepository) : base(repository)
        {
            _customerRepository = customerRepository;
            _orderdetailRepository = orderdetailRepository;
            //_ordermasterRepository = ordermasterRepository;
            GetPolicyName = BookStorePermissions.OrderMasters.Default;
            GetListPolicyName = BookStorePermissions.OrderMasters.Default;
            CreatePolicyName = BookStorePermissions.OrderMasters.Create;
            UpdatePolicyName = BookStorePermissions.OrderMasters.Edit;
            DeletePolicyName = BookStorePermissions.OrderMasters.Delete;
        }

        public async Task<ListResultDto<CustomerLookupDto>> GetCustomerLookupAsync()
        {
            var customers = await _customerRepository.GetListAsync();

            return new ListResultDto<CustomerLookupDto>(
               ObjectMapper.Map<List<Customer>, List<CustomerLookupDto>>(customers)
           );
        }

        public async Task<ListResultDto<OrderDetailLookupDto>> GetOrderDetailLookupAsync()
        {
            var customerss = await _orderdetailRepository.GetListAsync();

            return new ListResultDto<OrderDetailLookupDto>(
               ObjectMapper.Map<List<OrderDetail>, List<OrderDetailLookupDto>>(customerss));
        }
        public async Task CustomDeleteAsync(Guid id, OrderMasterDto input)
        {

            if (input.OnayBilgisi == true)
            {
                throw new OrderMasterApprovalStatusException();
            }

            await Repository.DeleteAsync(id);
        }
        public async Task CustomEditAsync(Guid id, OrderMasterDto input)
        {
            if (input.OnayBilgisi == true)
            {
                throw new OrderMasterApprovalStatusEditException();
            }

        }



        public override async Task<PagedResultDto<OrderMasterDto>> GetListAsync(PagedAndSortedResultRequestDto input)
        {
            //Get the IQueryable<Book> from the repository
            var queryable = await Repository.GetQueryableAsync();

            //Prepare a query to join books and authors
            var queryCustomer = from orderMaster in queryable
                                join customer in await _customerRepository.GetQueryableAsync() on orderMaster.CustomerId equals customer.Id
                                join orderDetail in await _orderdetailRepository.GetQueryableAsync() on orderMaster.OrderDetailId equals orderDetail.Id
                                select new { orderMaster, customer, orderDetail };

            //Paging
            //queryCustomer = queryCustomer
            //    .OrderBy(NormalizeSorting(input.Sorting))
            //    .Skip(input.SkipCount)
            //    .Take(input.MaxResultCount);

            //Execute the query and get a list
            var queryResultCustomer = await AsyncExecuter.ToListAsync(queryCustomer);


            //Convert the query result to a list of BookDto objects
            var omasterDtos = queryResultCustomer.Select(x =>
            {
                var omasterDto = ObjectMapper.Map<OrderMaster, OrderMasterDto>(x.orderMaster);
                omasterDto.CustomerName = x.customer.MusteriAd;
                omasterDto.StockName = x.orderDetail.StokAdi;
                return omasterDto;
            }).ToList();


            //Get the total count with another query
            var totalCount = await Repository.GetCountAsync();

            return new PagedResultDto<OrderMasterDto>(
                totalCount,
                omasterDtos
            //odetailDtos
            );
        }


    }
}
