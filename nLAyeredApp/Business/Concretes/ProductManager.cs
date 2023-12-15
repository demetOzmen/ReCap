using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public async Task<CreatedProductResponse> Add(CreateProductRequest createProductRequest)
        {
            Product product = new Product();
            //  product.Id = createProductRequest.CategoryId;
            product.ProductName = createProductRequest.ProductName;
            product.QuantityPerUnit = createProductRequest.QuantityPerUnit;
            product.UnitPrice = createProductRequest.UnitPrice;
            product.UnitsInStock = createProductRequest.UnitsInStock;

            Product createdProduct = await _productDal.AddAsync(product);

            CreatedProductResponse createdProductResponse = new CreatedProductResponse();
            createdProductResponse.Id = createdProduct.Id;
            createProductRequest.ProductName = createdProduct.ProductName;
            createProductRequest.QuantityPerUnit = createProductRequest.QuantityPerUnit;
            createProductRequest.UnitPrice = createProductRequest.UnitPrice;
            createProductRequest.UnitsInStock = createProductRequest.UnitsInStock;

            return createdProductResponse;
            // await _productDal.AddAsync(product);
        }

        //GetListProductResponse //mapping kullanmadan
        public async Task<Paginate<Product>> GetListAsync()
        {
            var result = await _productDal.GetListAsync();
            return result;
        }
    }
}
