using RealEstateWebApi.Dtos.ToDoListDtos;

namespace RealEstateWebApi.Repositories.ToDoListRepository
{
    public interface IToDoListRepository
    {
        Task<List<ResultToDoListDto>> GetAllToDoListsAsync();
        void AddToDoListAsync(CreateToDoListDto createToDoListDto);
        void DeleteToDoListAsync(int id);
        void UpdateToDoListAsync(UpdateToDoListDto updateToDoListDto);
        Task<ResultToDoListDto> GetToDoListByIdAsync(int id);
    }
}
