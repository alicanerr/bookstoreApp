using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace Acme.BookStore.OrderMasters
{
    public class OrderMasterApprovalStatusException : BusinessException
    {
        public OrderMasterApprovalStatusException()
           : base(BookStoreDomainErrorCodes.ApprovalStatusTrue)
        {
            //WithData("name", name);
        }
    }
}
