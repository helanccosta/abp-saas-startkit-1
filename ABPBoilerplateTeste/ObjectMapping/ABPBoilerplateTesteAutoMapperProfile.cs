using AutoMapper;
using ABPBoilerplateTeste.Entities.Books;
using ABPBoilerplateTeste.Services.Dtos.Books;

namespace ABPBoilerplateTeste.ObjectMapping;

public class ABPBoilerplateTesteAutoMapperProfile : Profile
{
    public ABPBoilerplateTesteAutoMapperProfile()
    {
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();
        CreateMap<BookDto, CreateUpdateBookDto>();
        /* Create your AutoMapper object mappings here */
    }
}