using Microsoft.AspNetCore.Mvc;
using RecommendationSystemApi.Data;
using RecommendationSystemApi.DTO.payloads;
using RecommendationSystemApi.Services;
using RecommendationSystemApi.Services.Interfaces;

namespace RecommendationSystemApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecomendController : ControllerBase
    {
        private readonly IMovieQueryService _movieQueryService;
        private readonly RSDBContext _context;
        private readonly ILogger<RecomendController> _logger;

        public RecomendController(ILogger<RecomendController> logger, RSDBContext context, IMovieQueryService movieQueryService)
        {
            _logger = logger;
            _context = context;
            _movieQueryService = movieQueryService;
        }

        [HttpPost]
        public async Task<IActionResult> QueryMovies([FromBody] MovieQueryModel query)
        {
            try
            {
                var result = await _movieQueryService.QueryMoviesAsync(query);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

    }

}