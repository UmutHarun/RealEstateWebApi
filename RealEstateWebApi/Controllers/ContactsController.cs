using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstateWebApi.Repositories.ContactRepository;

namespace RealEstateWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IContactRepository _contactRepository;

        public ContactsController(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        [HttpGet("Last4Contact")]
        public async Task<IActionResult> GetLast4ContactsAsync()
        {
            var values = await _contactRepository.GetLast4ContactAsync();
            return Ok(values);
        }
    }
}
