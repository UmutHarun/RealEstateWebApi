using RealEstateWebApi.Dtos.CategoryDtos;
using RealEstateWebApi.Dtos.WhoWeAreDetailDtos;

namespace RealEstateWebApi.Repositories.WhoWeAreRepository
{
    public interface IWhoWeAreRepository
    {
        Task<List<ResultWhoWeAreDetailDto>> GetAllWhoWeAreDetailsAsync();
        void AddWhoWeAreDetailAsync(AddWhoWeAreDetailDto addWhoWeAreDetailDto);
        void DeleteWhoWeAreDetailAsync(int id);
        void UpdateWhoWeAreDetailAsync(UpdateWhoWeAreDetailDto updateWhoWeAreDetailDto);
        Task<ResultWhoWeAreDetailDto> GetWhoWeAreDetailByIdAsync(int id);
    }
}
