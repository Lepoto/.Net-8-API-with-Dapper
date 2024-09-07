using Dapper;
using Dapper.Crud.API.Models;
using System.Data.SqlClient;

namespace Dapper.Crud.API.Repositories
{
    public class VideoGameRepository : IVideoGameRepository
    {
        private readonly IConfiguration _configuration;

        public VideoGameRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<List<VideoGame>> GetAllAsync()
        {
            using var connection = GetConnection();

            // Define the SQL query to get all video games
            var sql = "SELECT * FROM VideoGames";

            // Execute the query and return the result as a list of VideoGame objects
            var videoGames = await connection
                .QueryAsync<VideoGame>(sql);

            return videoGames.ToList();
        }

        private SqlConnection GetConnection()
        {
            return new SqlConnection(
                _configuration.GetConnectionString("VideoGameConnectionString")
            );
        }
    }
}
