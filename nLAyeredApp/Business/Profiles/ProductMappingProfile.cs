using AutoMapper;
using Core.DataAccess.Paging;
using Core.Dtos.Requests;
using Core.Dtos.Responses;
using Entities.Concretes;

namespace Core.Profiles;

public class ProductMappingProfile : Profile
{
    public ProductMappingProfile()
    {
        CreateMap<Product, GetListProductResponse>()
            .ForMember(destinationMember: p => p.CategoryName,
                       memberOptions: opt => opt.MapFrom(p => p.Category.Name))
            .ReverseMap();

        CreateMap<Paginate<Product>, Paginate<GetListProductResponse>>();
        CreateMap<Product, CreateProductRequest>().ReverseMap();
        CreateMap<Product, CreatedProductResponse>().ReverseMap();
    }

}