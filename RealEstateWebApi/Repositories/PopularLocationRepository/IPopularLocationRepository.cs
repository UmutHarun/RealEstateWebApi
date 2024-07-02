using RealEstateWebApi.Dtos.PopularLocationDtos;

namespace RealEstateWebApi.Repositories.PopularLocationRepository
{
    public interface IPopularLocationRepository
    {
        Task<List<ResultPopularLocationDto>> GetAllPopularLocationsAsync();
        void AddPopularLocationAsync(AddPopularLocationDto addPopularLocationDto);
        void DeletePopularLocationAsync(int id);
        void UpdatePopularLocationAsync(UpdatePopularLocationDto updatePopularLocationDto);
        Task<ResultPopularLocationDto> GetPopularLocationByIdAsync(int id);
    }
}
