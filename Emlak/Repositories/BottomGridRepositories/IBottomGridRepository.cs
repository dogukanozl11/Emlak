using Emlak_Api.Dtos.BottomGridDtos;
using Emlak_Api.Dtos.CategoryDtos;
using Emlak_Api.Dtos.ServiceDtos;

namespace Emlak_Api.Repositories.BottomGridRepositories
{
    public interface IBottomGridRepository
    {
        Task<List<ResultBottomGridDto>> GetAllBottomGridAsync();
        void CreateBottomGrid(CreateBottomGridDto createBottomGridDto);
        void DeleteBottomGrid(int id);
        void UpdateBottomGrid(UpdateBotomGridDto updateBotomGridDto);
        Task<GetBottomGridDto> GetBottomGrid(int id);
    }
}
