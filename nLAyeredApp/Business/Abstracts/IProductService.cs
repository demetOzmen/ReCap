using Core.Dtos.Requests;
using Core.Dtos.Responses;
using Core.DataAccess.Paging;

namespace Core.Abstracts;

public interface IProductService
{
    Task<IPaginate<GetListProductResponse>> GetListAsync(PageRequest pageRequest);
    Task<CreatedProductResponse> Add(CreateProductRequest createProductRequest);
}