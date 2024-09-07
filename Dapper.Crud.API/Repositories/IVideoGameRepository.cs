using Dapper.Crud.API.Models;

namespace Dapper.Crud.API.Repositories
{
    public interface IVideoGameRepository
    {
        Task<List<VideoGame>> GetAllAsync();

    }
}
