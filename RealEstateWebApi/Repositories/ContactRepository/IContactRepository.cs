using RealEstateWebApi.Dtos.ContactDtos;

namespace RealEstateWebApi.Repositories.ContactRepository
{
    public interface IContactRepository
    {
        Task<List<ResultContactDto>> GetAllContactsAsync();
        Task<List<Last4ContactResultDto>> GetLast4ContactAsync();
        void AddContactAsync(CreateContactDto createContactDto);
        void DeleteContactAsync(int id);
        Task<ResultContactDto> GetContactByIdAsync(int id);
    }
}
