using RealEstateWebApi.Dtos.ChartDtos;

namespace RealEstateWebApi.Repositories.EstateAgentRepositories.DashboardRepositories.ChartRepositories
{
    public interface IChartRepository
    {
        Task<List<ResultChartDto>> Get5CityForChart();
    }
}
