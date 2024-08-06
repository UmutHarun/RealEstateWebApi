using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstateWebApi.Repositories.MessageRepository;

namespace RealEstateWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private readonly IMessageRepository _messageRepository;

        public MessagesController(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetInboxLast3MessageListByReceiver(int id)
        {
            var values = await _messageRepository.GetInboxLast3MessageListByReceiver(id);
            return Ok(values);
        }
    }
}
