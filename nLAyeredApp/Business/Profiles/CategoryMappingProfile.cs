using AutoMapper;
using Core.Dtos.Requests;
using Core.Dtos.Responses;
using Entities.Concretes;

namespace Core.Profiles;

public class CategoryMappingProfile : Profile
{
    public CategoryMappingProfile()
    {
        CreateMap<Category, CreateCategoryRequest>().ReverseMap();
        CreateMap<Category, CreatedCategoryResponse>().ReverseMap();
    }

}