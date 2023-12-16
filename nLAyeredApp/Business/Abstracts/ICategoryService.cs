using Core.Dtos.Requests;
using Core.Dtos.Responses;

namespace Core.Abstracts;

public interface ICategoryService
{
    Task<CreatedCategoryResponse> Add(CreateCategoryRequest createCategoryRequest);
}