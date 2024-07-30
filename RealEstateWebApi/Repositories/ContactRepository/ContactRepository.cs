using Dapper;
using RealEstateWebApi.Dtos.ContactDtos;
using RealEstateWebApi.Models.DapperContext;

namespace RealEstateWebApi.Repositories.ContactRepository
{
    public class ContactRepository : IContactRepository
    {
        private readonly Context _context;

        public ContactRepository(Context context)
        {
            _context = context;
        }

        public void AddContactAsync(CreateContactDto createContactDto)
        {
            throw new NotImplementedException();
        }

        public void DeleteContactAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResultContactDto>> GetAllContactsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ResultContactDto> GetContactByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Last4ContactResultDto>> GetLast4ContactAsync()
        {
            string query = "Select Top(4) * From Contact order by ContactId Desc";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<Last4ContactResultDto>(query);
                return values.ToList();
            }
        }
    }
}
