using System;
using ABPBoilerplateTeste.Permissions;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using ABPBoilerplateTeste.Services.Dtos.Books;
using ABPBoilerplateTeste.Entities.Books;

namespace ABPBoilerplateTeste.Services.Books;

public class BookAppService :
    CrudAppService<
        Book, //The Book entity
        BookDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateBookDto>, //Used to create/update a book
    IBookAppService //implement the IBookAppService
{
    public BookAppService(IRepository<Book, Guid> repository)
        : base(repository)
    {
        GetPolicyName = ABPBoilerplateTestePermissions.Books.Default;
        GetListPolicyName = ABPBoilerplateTestePermissions.Books.Default;
        CreatePolicyName = ABPBoilerplateTestePermissions.Books.Create;
        UpdatePolicyName = ABPBoilerplateTestePermissions.Books.Edit;
        DeletePolicyName = ABPBoilerplateTestePermissions.Books.Delete;
    }
}