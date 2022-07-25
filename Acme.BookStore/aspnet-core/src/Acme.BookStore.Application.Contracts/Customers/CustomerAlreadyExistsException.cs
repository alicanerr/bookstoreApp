using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp;

namespace Acme.BookStore.Customers
{
    public class CustomerAlreadyExistsException : BusinessException
    {
        //public CustomerAlreadyExistsException(string name)
        //    : base(BookStoreDomainErrorCodes.CustomerAlreadyExists)
        //{
        //    WithData("name", name);
        //}
    }
}
