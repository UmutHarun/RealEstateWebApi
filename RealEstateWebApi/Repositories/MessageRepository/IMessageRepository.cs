using RealEstateWebUI.Dtos.MessageDtos;

namespace RealEstateWebApi.Repositories.MessageRepository
{
    public interface IMessageRepository
    {
        Task<List<ResultInboxMessageDto>> GetInboxLast3MessageListByReceiver(int id);
    }
}
