using RealEstateWebApi.Dtos.BottomGridDtos;

namespace RealEstateWebApi.Repositories.BottomGridRepository
{
    public interface IBottomGridRepository
    {
        Task<List<ResultBottomGridDto>> GetAllBottomGridsAsync();
        void AddBottomGridAsync(AddBottomGridDto addBottomGridDto);
        void DeleteBottomGridAsync(int id);
        void UpdateBottomGridAsync(UpdateBottomGridDto updateBottomGridDto);
        Task<ResultBottomGridDto> GetBottomGridByIdAsync(int id);
    }
}
