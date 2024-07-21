using Emlak_Api.Dtos.MessageDtos;

namespace Emlak_Api.Repositories.MessageRepositories
{
    public interface IMessageRepository
    {
        Task<List<ResultInBoxMessageDto>> GetInBoxLast3MessageListByReceiver(int id);
    }
}
