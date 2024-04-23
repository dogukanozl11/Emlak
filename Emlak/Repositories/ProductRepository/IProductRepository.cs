using Emlak_Api.Dtos.CategoryDtos;
using Emlak_Api.Dtos.ProductDtos;

namespace Emlak_Api.Repositories.ProductRepository
{
    public interface IProductRepository
    {
        Task<List<ResultProductDto>> GetAllProductAsync();
        Task<List<ResultProductWhitCategoryDto>> GetResultProductWhitCategoryAsync();
    }
}
