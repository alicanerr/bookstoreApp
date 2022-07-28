using Acme.BookStore.Authors;
using Acme.BookStore.Books;
using Acme.BookStore.Customers;
using Acme.BookStore.OrderDetails;
using Acme.BookStore.OrderMasters;
using AutoMapper;

namespace Acme.BookStore;

public class BookStoreApplicationAutoMapperProfile : Profile
{
    public BookStoreApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Book, BookDto>();
        //CreateMap<Book, BookCacheItem>();
        CreateMap<CreateUpdateBookDto, Book>();

        CreateMap<Customer, CustomerDto>();
        CreateMap<CreateUpdateCustomerDto, Customer>();

        CreateMap<OrderDetail,OrderDetailDto>();
        CreateMap<OrderDetail,OrderDetailLookupDto>();


        CreateMap<CreateUpdateOrderDetailDto,OrderDetail>();

        CreateMap<OrderMaster,OrderMasterDto>();
        CreateMap<CreateUpdateOrderMasterDto,OrderMaster>();

        CreateMap<Customer, CustomerLookupDto>();

        CreateMap<Author, AuthorDto>();
        CreateMap<Author, AuthorCacheItem>();
        CreateMap<Author, AuthorLookupDto>();


    }
}
