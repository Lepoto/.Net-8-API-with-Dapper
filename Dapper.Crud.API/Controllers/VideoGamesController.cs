using Dapper.Crud.API.Models;
using Dapper.Crud.API.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dapper.Crud.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoGamesController : ControllerBase
    {
        private readonly IVideoGameRepository _videoGameRepository;

        public VideoGamesController(IVideoGameRepository videoGameRepository)
        {
            _videoGameRepository = videoGameRepository;   
        }

        [HttpGet]
        public async Task<ActionResult<List<VideoGame>>> GetAllAsync() 
        {
            var videoGames = await _videoGameRepository.GetAllAsync();
            return Ok(videoGames);
        }
    }
}
