namespace RealEstateWebApi.Repositories.EstateAgentRepositories.DashboardRepositories.StatisticRepositories
{
    public interface IAgentStatisticRepository
    {
        int ProductCountByEmployeeId(int id);
        int ProductCountByTrueStatus(int id);
        int ProductCountByFalseStatus(int id);
        int AllProductCount();

    }
}
