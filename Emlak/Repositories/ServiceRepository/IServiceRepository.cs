using Emlak_Api.Dtos.CategoryDtos;
using Emlak_Api.Dtos.ServiceDtos;

namespace Emlak_Api.Repositories.ServiceRepository
{
    public interface IServiceRepository
    {
        Task<List<ResultServiceDto>> GetAllService();
        Task CreateService(CreateServiceDto createServiceDto);
        Task DeleteService(int id);
        Task UpdateService(UptadeServiceDto updateServiceDto);
        Task<GetByIDServiceDto> GetService(int id);
    }
}
