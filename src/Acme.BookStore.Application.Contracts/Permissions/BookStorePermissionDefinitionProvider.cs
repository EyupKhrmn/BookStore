using System.Net.Mime;
using Acme.BookStore.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Acme.BookStore.Permissions;

public class BookStorePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var BookStoreGroup = context.AddGroup(BookStorePermissions.GroupName, L(
            "Permission:BookStore"));

        var BooksPermission = BookStoreGroup.AddPermission(BookStorePermissions.Books.Default, L("Permissions:Books"));
        BooksPermission = BookStoreGroup.AddPermission(BookStorePermissions.Books.Create, L("Permissions:Create"));
        BooksPermission = BookStoreGroup.AddPermission(BookStorePermissions.Books.Edit, L("Permissions:Edit"));
        BooksPermission = BookStoreGroup.AddPermission(BookStorePermissions.Books.Delete, L("Permissions:Delete"));
        
        
        
        var authorsPermission = BookStoreGroup.AddPermission(
            BookStorePermissions.Authors.Default, L("Permission:Authors"));
        authorsPermission.AddChild(
            BookStorePermissions.Authors.Create, L("Permission:Authors.Create"));
        authorsPermission.AddChild(
            BookStorePermissions.Authors.Edit, L("Permission:Authors.Edit"));
        authorsPermission.AddChild(
            BookStorePermissions.Authors.Delete, L("Permission:Authors.Delete"));

    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<BookStoreResource>(name);
    }
}
