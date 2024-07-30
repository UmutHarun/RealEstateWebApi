using Dapper;
using RealEstateWebApi.Dtos.ToDoListDtos;
using RealEstateWebApi.Models.DapperContext;

namespace RealEstateWebApi.Repositories.ToDoListRepository
{
    public class ToDoListRepository : IToDoListRepository
    {
        private readonly Context _context;

        public ToDoListRepository(Context context)
        {
            _context = context;
        }

        public void AddToDoListAsync(CreateToDoListDto createToDoListDto)
        {
            throw new NotImplementedException();
        }

        public void DeleteToDoListAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ResultToDoListDto>> GetAllToDoListsAsync()
        {
            string query = "Select * From ToDoList";
            using var connection = _context.CreateConnection();
            var values = await connection.QueryAsync<ResultToDoListDto>(query);
            return values.ToList();
        }

        public Task<ResultToDoListDto> GetToDoListByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateToDoListAsync(UpdateToDoListDto updateToDoListDto)
        {
            throw new NotImplementedException();
        }
    }
}
