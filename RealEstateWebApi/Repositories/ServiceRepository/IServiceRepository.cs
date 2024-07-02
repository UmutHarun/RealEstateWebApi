using RealEstateWebApi.Dtos.ServiceDtos;

namespace RealEstateWebApi.Repositories.ServiceRepository
{
    public interface IServiceRepository
    {
        Task<List<ResultServiceDto>> GetAllServicesAsync();
        void AddServiceAsync(AddServiceDto addServiceDto);
        void DeleteServiceAsync(int id);
        void UpdateServiceAsync(UpdateServiceDto updateServiceDto);
        Task<ResultServiceDto> GetServiceByIdAsync(int id);
    }
}
