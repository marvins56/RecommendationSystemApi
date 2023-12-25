using RecommendationSystemApi.DTO.payloads;
using RecommendationSystemApi.DTO.requests;

namespace RecommendationSystemApi.Services.Interfaces
{
    public interface IMovieQueryService
    {
        Task<QueryResultModel> QueryMoviesAsync(MovieQueryModel query);

    }
}
