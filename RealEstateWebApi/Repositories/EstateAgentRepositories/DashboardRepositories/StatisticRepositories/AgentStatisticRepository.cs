using Dapper;
using RealEstateWebApi.Models.DapperContext;

namespace RealEstateWebApi.Repositories.EstateAgentRepositories.DashboardRepositories.StatisticRepositories
{
    public class AgentStatisticRepository : IAgentStatisticRepository
    {

        private readonly Context _context;

        public AgentStatisticRepository(Context context)
        {
            _context = context;
        }

        public int AllProductCount()
        {
            string query = "Select Count(*) From Product";
            using var connection = _context.CreateConnection();
            var values = connection.QueryFirstOrDefault<int>(query);
            return values;
        }

        public int ProductCountByEmployeeId(int id)
        {
            string query = "Select Count(*) From Product Where EmployeeId=@employeeId";
            var parameters = new DynamicParameters();
            parameters.Add("@employeeId", id);
            using var connection = _context.CreateConnection();
            var values = connection.QueryFirstOrDefault<int>(query,parameters);
            return values;
        }

        public int ProductCountByFalseStatus(int id)
        {
            string query = "Select Count(*) From Product Where EmployeeId=@employeeId And Status=0";
            var parameters = new DynamicParameters();
            parameters.Add("@employeeId", id);
            using var connection = _context.CreateConnection();
            var values = connection.QueryFirstOrDefault<int>(query, parameters);
            return values;
        }

        public int ProductCountByTrueStatus(int id)
        {
            string query = "Select Count(*) From Product Where EmployeeId=@employeeId And Status=1";
            var parameters = new DynamicParameters();
            parameters.Add("@employeeId", id);
            using var connection = _context.CreateConnection();
            var values = connection.QueryFirstOrDefault<int>(query, parameters);
            return values;
        }
    }
}
