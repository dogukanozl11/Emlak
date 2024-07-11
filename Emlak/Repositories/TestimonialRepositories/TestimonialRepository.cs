using Dapper;
using Emlak_Api.Dtos.TestimonialDtos;
using Emlak_Api.Models.DapperContext;

namespace Emlak_Api.Repositories.TestimonialRepositories
{
    public class TestimonialRepository : ITestimonialRepository
    {
        private readonly Context _context;

        public TestimonialRepository(Context context)
        {
            _context = context;
        }
        public async Task<List<ResultTestimonialDto>> GetAllTestimonialAsync()
        {
            string query = "Select * from Testimonial";
            using (var connection = _context.CreateConnection())
            {

                var values = await connection.QueryAsync<ResultTestimonialDto>(query);
                return values.ToList();
            }
        }
    }
}
