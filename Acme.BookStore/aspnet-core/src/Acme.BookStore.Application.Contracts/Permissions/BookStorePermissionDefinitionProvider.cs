using Acme.BookStore.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Acme.BookStore.Permissions
{
    public class BookStorePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var bookStoreGroup = context.AddGroup(BookStorePermissions.GroupName, L("Permission:BookStore"));

            var booksPermission = bookStoreGroup.AddPermission(BookStorePermissions.Books.Default, L("Permission:Books"));
            booksPermission.AddChild(BookStorePermissions.Books.Create, L("Permission:Books.Create"));
            booksPermission.AddChild(BookStorePermissions.Books.Edit, L("Permission:Books.Edit"));
            booksPermission.AddChild(BookStorePermissions.Books.Delete, L("Permission:Books.Delete"));

       

            var customersPermission = bookStoreGroup.AddPermission(BookStorePermissions.Customers.Default, L("Permission:Customers"));
            customersPermission.AddChild(BookStorePermissions.Customers.Create, L("Permission:Customers.Create"));
            customersPermission.AddChild(BookStorePermissions.Customers.Edit, L("Permission:Customers.Edit"));
            customersPermission.AddChild(BookStorePermissions.Customers.Delete, L("Permission:Customers.Delete"));

            var orderDetailPermission = bookStoreGroup.AddPermission(BookStorePermissions.OrderDetails.Default, L("Permission:OrderDetails"));
            orderDetailPermission.AddChild(BookStorePermissions.OrderDetails.Create, L("Permission:OrderDetails.Create"));
            orderDetailPermission.AddChild(BookStorePermissions.OrderDetails.Edit, L("Permission:OrderDetails.Edit"));
            orderDetailPermission.AddChild(BookStorePermissions.OrderDetails.Delete, L("Permission:OrderDetails.Delete"));

            var authorsPermission = bookStoreGroup.AddPermission(
    BookStorePermissions.Authors.Default, L("Permission:Authors"));

            authorsPermission.AddChild(
                BookStorePermissions.Authors.Create, L("Permission:Authors.Create"));

            authorsPermission.AddChild(
                BookStorePermissions.Authors.Edit, L("Permission:Authors.Edit"));

            authorsPermission.AddChild(
                BookStorePermissions.Authors.Delete, L("Permission:Authors.Delete"));

            var ordermasterPermission = bookStoreGroup.AddPermission(BookStorePermissions.OrderMasters.Default, L("Permission:OrderMasters"));
            ordermasterPermission.AddChild(BookStorePermissions.OrderMasters.Create, L("Permission:OrderMasters.Create"));
            ordermasterPermission.AddChild(BookStorePermissions.OrderMasters.Edit, L("Permission:OrderMasters.Edit"));
            ordermasterPermission.AddChild(BookStorePermissions.OrderMasters.Delete, L("Permission:OrderMasters.Delete"));

        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<BookStoreResource>(name);
        }
    }
}
