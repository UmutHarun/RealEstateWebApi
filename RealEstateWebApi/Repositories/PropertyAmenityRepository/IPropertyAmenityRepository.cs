using RealEstateWebApi.Dtos.PropertyAmenityDtos;

namespace RealEstateWebApi.Repositories.PropertyAmenityRepository
{
    public interface IPropertyAmenityRepository
    {
        Task<List<ResultPropertyAmenityByTrueStatusDto>> GetResultPropertyAmenityByTrueStatus(int id);
    }
}
