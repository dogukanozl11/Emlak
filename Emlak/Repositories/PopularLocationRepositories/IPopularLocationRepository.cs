using Emlak_Api.Dtos.BottomGridDtos;
using Emlak_Api.Dtos.PopularLocationDtos;

namespace Emlak_Api.Repositories.PopularLocationRepositories
{
    public interface IPopularLocationRepository
    {
        Task<List<ResultPopularLocationDto>> GetAllPopularLocationAsync();
        
    }
}
