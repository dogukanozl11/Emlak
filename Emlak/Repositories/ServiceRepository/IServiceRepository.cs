using Emlak_Api.Dtos.CategoryDtos;
using Emlak_Api.Dtos.ServiceDtos;

namespace Emlak_Api.Repositories.ServiceRepository
{
    public interface IServiceRepository
    {
        Task<List<ResultServiceDto>> GetAllServiceAsync();
        void CreateService(CreateServiceDto createServiceDto);
        void DeleteService(int id);
        void UpdateService(UpdateCategoryDto updateServiceDto);
        Task<GetByIDServiceDto> GetService(int id);
    }
}
