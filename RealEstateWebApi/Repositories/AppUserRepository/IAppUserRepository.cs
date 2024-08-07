using RealEstateWebApi.Dtos.AppUserDtos;

namespace RealEstateWebApi.Repositories.AppUserRepository
{
    public interface IAppUserRepository
    {
        Task<GetAppUserByProductId> GetAppUserByProductId(int id);
    }
}
