using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace Acme.BookStore.OrderMasters
{
    public class OrderMasterApprovalStatusEditException : BusinessException
    {
        public OrderMasterApprovalStatusEditException()
           : base(BookStoreDomainErrorCodes.ApprovalStatusEdit)
        {
        }
    }
}
