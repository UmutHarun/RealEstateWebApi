using Dapper;
using RealEstateWebApi.Models.DapperContext;
using RealEstateWebUI.Dtos.MessageDtos;

namespace RealEstateWebApi.Repositories.MessageRepository
{
    public class MessageRepository : IMessageRepository
    {
        private readonly Context _context;

        public MessageRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<ResultInboxMessageDto>> GetInboxLast3MessageListByReceiver(int id)
        {
            string query = "Select Top(3) MessageId,Name,Subject,Detail,SendDate,IsRead,ImageUrl From Message" +
                " Inner Join AppUser On Message.Sender=AppUser.UserId Where Receiver=@receiverId Order By MessageId Desc";
            var parameters = new DynamicParameters();
            parameters.Add("@receiverId", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultInboxMessageDto>(query, parameters);
                return values.ToList();

            }
        }
    }
}
