using AutoMapper;
using SerializeAndDeserialize.Domain;
using SerializeAndDeserialize.Entity;

namespace SerializeAndDeserialize.Mapper;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<Book, BookEntity>()
            .ForMember(dest => dest.AuthorJson, opt => opt.MapFrom(src => JsonHelper.SerializeObject(src.Author)));

        CreateMap<BookEntity, Book>()
            .ForMember(dest => dest.Author, opt => opt.MapFrom(src => JsonHelper.DeserializeObject<Author>(src.AuthorJson)));
    }
}