using Emlak_Api.Dtos.TestimonialDtos;

namespace Emlak_Api.Repositories.TestimonialRepositories
{
    public interface ITestimonialRepository
    {
        Task<List<ResultTestimonialDto>> GetAllTestimonialAsync();
      
    }
}
