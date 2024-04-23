using Dapper;
using Emlak_Api.Dtos.CategoryDtos;
using Emlak_Api.Dtos.ProductDtos;
using Emlak_Api.Models.DapperContext;

namespace Emlak_Api.Repositories.ProductRepository
{
    public class ProductRepository : IProductRepository
    {
        private readonly Context _context;

        public ProductRepository(Context context)
        {
            _context = context;
        }
        public async Task<List<ResultProductDto>> GetAllProductAsync()
        {
            string query = "Select * from Product";
            using (var connection = _context.CreateConnection())
            {

                var values = await connection.QueryAsync<ResultProductDto>(query);
                return values.ToList();
            }
        }

        public async Task<List<ResultProductWhitCategoryDto>> GetResultProductWhitCategoryAsync()
        {
            string query = "Select ProductID,Title,Price,City,District,CategoryName From Product inner join Category on Product.ProductCategory=Category.CategoryID";
            using (var connection = _context.CreateConnection())
            {

                var values = await connection.QueryAsync<ResultProductWhitCategoryDto>(query);
                return values.ToList();
            }
        }
    }
}
