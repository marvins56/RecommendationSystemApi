using RecommendationSystemApi.Models;
using static Microsoft.Extensions.Logging.EventSource.LoggingEventSource;

namespace RecommendationSystemApi.DTO.requests
{
    // QueryResultModel.cs
    public class QueryResultModel
    {

        public List<MovieMetadata> Moviesmetadata { get; set; }
        public List<ExpandedKeyword> Keywords { get; set; }
        public List<Genre> genre { get; set; }
        public List<Rating> ratings { get; set; }
        public List<ProductionCountry> productionCountry { get; set; }
        public List<ProductionCompany> productionCompany { get; set; }
        public List<SpokenLanguage> spokenLanguage { get; set; }
        public List<CreditsCrew> creditsCrew { get; set; }
        // Add other properties for related data from different tables
    }

}
