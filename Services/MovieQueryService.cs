using Microsoft.EntityFrameworkCore;
using RecommendationSystemApi.Data;
using RecommendationSystemApi.DTO.payloads;
using RecommendationSystemApi.DTO.requests;
using RecommendationSystemApi.Models;
using RecommendationSystemApi.Services.Interfaces;

namespace RecommendationSystemApi.Services
{
    // MovieQueryService.cs
    public class MovieQueryService : IMovieQueryService
    {
        private readonly RSDBContext _context;

        public MovieQueryService(RSDBContext context)
        {
            _context = context;
        }

        public async Task<QueryResultModel> QueryMoviesAsync(MovieQueryModel query)
        {
            var result = new QueryResultModel
            {
                Moviesmetadata = new List<MovieMetadata>(),
                Keywords = new List<ExpandedKeyword>(),
                genre = new List<Genre>(),
                ratings = new List<Rating>(),
                productionCountry = new List<ProductionCountry>(),
                productionCompany = new List<ProductionCompany>(),
                spokenLanguage = new List<SpokenLanguage>(),
                creditsCrew = new List<CreditsCrew>()
                // Add other related data properties as needed
            };

            // Step 1: Get the movies by name
            var movies = await _context.MoviesMetadata
                .Where(m => m.Title.Contains(query.MovieName))
                .ToListAsync();

            if (movies.Any())
            {
                // Step 2: Populate movie metadata
                result.Moviesmetadata.AddRange(movies.Select(movie => new MovieMetadata
                {
                    MovieId = movie.MovieId,
                    Title = movie.Title,
                    // Populate other movie properties
                }));

                // Step 3: Populate related data for each movie
                foreach (var movie in movies)
                {
                    var genreData = await _context.Set<Genre>()
                        .Where(g => g.MovieId == movie.MovieId)
                        .ToListAsync();
                    result.genre.AddRange(genreData);

                    var ratingData = await _context.Set<Rating>()
                        .Where(r => r.MovieId == movie.MovieId)
                        .ToListAsync();
                    result.ratings.AddRange(ratingData);

                    var productionCountryData = await _context.Set<ProductionCountry>()
                        .Where(pc => pc.MovieId == movie.MovieId)
                        .ToListAsync();
                    result.productionCountry.AddRange(productionCountryData);

                    var productionCompanyData = await _context.Set<ProductionCompany>()
                        .Where(pc => pc.MovieId == movie.MovieId)
                        .ToListAsync();
                    result.productionCompany.AddRange(productionCompanyData);

                    // Add logic to populate other related data for each movie

                    // Step 4: Recommend similar movies for each movie
                    if (!string.IsNullOrEmpty(query.Genre) || !string.IsNullOrEmpty(query.Keyword) || query.MinRating > 0)
                    {
                        var recommendedMovies = await GetRecommendedMoviesAsync(query, movies);
                        result.Moviesmetadata.AddRange(recommendedMovies);
                    }
                }
            }
            else
            {
                // Step 5: Movies not found, recommend movies based on genres and ratings from the request
                var genreBasedRecommendations = await GetGenreBasedRecommendationsAsync(query);
                result.Moviesmetadata.AddRange(genreBasedRecommendations);
            }

            return result;
        }





        //public async Task<QueryResultModel> QueryMoviesAsync(MovieQueryModel query)
        //{
        //    var result = new QueryResultModel
        //    {
        //        Moviesmetadata = new List<MovieMetadata>(),
        //        Keywords = new List<ExpandedKeyword>(),
        //        genre = new List<Genre>(),
        //        ratings = new List<Rating>(),
        //        productionCountry = new List<ProductionCountry>(),
        //        productionCompany = new List<ProductionCompany>(),
        //        spokenLanguage = new List<SpokenLanguage>(),
        //        creditsCrew = new List<CreditsCrew>()
        //        // Add other related data properties as needed
        //    };

        //    // Step 1: Get the movie by name
        //    var movie = await _context.MoviesMetadata
        //        .FirstOrDefaultAsync(m => m.Title.Contains(query.MovieName));

        //    if (movie != null)
        //    {
        //        // Step 2: Populate movie metadata
        //        result.Moviesmetadata.Add(new MovieMetadata
        //        {
        //            MovieId = movie.MovieId,
        //            Title = movie.Title,
        //            Adult = movie.Adult,
        //            Budget = movie.Budget,
        //            Homepage = movie.Homepage,
        //            ImdbId = movie.ImdbId,
        //            OriginalLanguage = movie.OriginalLanguage,
        //            OriginalTitle = movie.OriginalTitle,
        //            Overview = movie.Overview,
        //            Popularity = movie.Popularity,
        //            PosterPath = movie.PosterPath,
        //            ReleaseDate = movie.ReleaseDate,
        //            Revenue = movie.Revenue,
        //            Runtime = movie.Runtime,
        //            Status = movie.Status,
        //            Tagline = movie.Tagline,
        //            Video = movie.Video,
        //            VoteAverage = movie.VoteAverage,
        //            VoteCount = movie.VoteCount,
        //        });

        //        // Step 3: Populate related data manually
        //        var genreData = await _context.Set<Genre>()
        //            .Where(g => g.MovieId == movie.MovieId)
        //            .ToListAsync();
        //        result.genre.AddRange(genreData);

        //        var ratingData = await _context.Set<Rating>()
        //            .Where(r => r.MovieId == movie.MovieId)
        //            .ToListAsync();
        //        result.ratings.AddRange(ratingData);

        //        var productionCountryData = await _context.Set<ProductionCountry>()
        //            .Where(pc => pc.MovieId == movie.MovieId)
        //            .ToListAsync();
        //        result.productionCountry.AddRange(productionCountryData);

        //        var productionCompanyData = await _context.Set<ProductionCompany>()
        //            .Where(pc => pc.MovieId == movie.MovieId)
        //            .ToListAsync();
        //        result.productionCompany.AddRange(productionCompanyData);

        //        //var spokenLanguageData = await _context.Set<SpokenLanguage>()
        //        //    .Where(sl => sl.MovieId == movie.MovieId)
        //        //    .ToListAsync();
        //        //result.spokenLanguage.AddRange(spokenLanguageData);

        //        //var creditsCrewData = await _context.Set<CreditsCrew>()
        //        //    .Where(cc => cc.MovieId == movie.MovieId)
        //        //    .ToListAsync();
        //        //result.creditsCrew.AddRange(creditsCrewData);

        //        // Step 4: Recommend similar movies
        //        if (!string.IsNullOrEmpty(query.Genre) || !string.IsNullOrEmpty(query.Keyword) || query.MinRating > 0)
        //        {
        //            //var recommendedMovies = await GetRecommendedMoviesAsync(query, movie);
        //            //result.Moviesmetadata.AddRange(recommendedMovies);
        //            // Inside QueryMoviesAsync method
        //            var recommendedMovies = await GetRecommendedMoviesAsync(query, result.Moviesmetadata);
        //            result.Moviesmetadata.AddRange(recommendedMovies);

        //        }
        //    }
        //    else
        //    {
        //        // Step 5: Movie not found, recommend movies based on genres and ratings from the request
        //        var genreBasedRecommendations = await GetGenreBasedRecommendationsAsync(query);
        //        result.Moviesmetadata.AddRange(genreBasedRecommendations);
        //    }

        //    return result;
        //}

        //private async Task<List<MovieMetadata>> GetRecommendedMoviesAsync(MovieQueryModel query, MovieMetadata baseMovie)
        //{
        //    // Assuming genres are stored in a separate table and associated with movies using MovieId
        //    var genreBasedMovies = await _context.Set<Genre>()
        //        .Where(g => g.MovieId == baseMovie.MovieId)
        //        .Select(g => g.Name)
        //        .ToListAsync();

        //    var recommendedMovies = await _context.Set<MovieMetadata>()
        //        .Where(m =>
        //            _context.Genres.Any(g => g.MovieId == m.MovieId && genreBasedMovies.Contains(g.Name)) && // Filter by genres
        //            m.Overview.Contains(baseMovie.Overview) && // Filter by description
        //            _context.Set<Rating>()
        //                .Where(r => r.MovieId == m.MovieId)
        //                .Average(r => r.RatingValue) >= query.MinRating && // Filter by ratings
        //            m.MovieId != baseMovie.MovieId) // Exclude the base movie
        //        .OrderByDescending(m => _context.Ratings
        //            .Where(r => r.MovieId == m.MovieId)
        //            .Average(r => r.RatingValue))
        //        .Take(query.MaxResults > 0 ? query.MaxResults : 10)
        //        .ToListAsync();

        //    return recommendedMovies;
        //}

        private async Task<List<MovieMetadata>> GetRecommendedMoviesAsync(MovieQueryModel query, List<MovieMetadata> baseMovies)
        {
            var recommendedMovies = new List<MovieMetadata>();

            foreach (var baseMovie in baseMovies)
            {
                var genreBasedMovies = await _context.Set<Genre>()
                    .Where(g => g.MovieId == baseMovie.MovieId)
                    .Select(g => g.Name)
                    .ToListAsync();

                var movies = await _context.Set<MovieMetadata>()
                    .Where(m =>
                        _context.Genres.Any(g => g.MovieId == m.MovieId && genreBasedMovies.Contains(g.Name)) && // Filter by genres
                        m.Overview.Contains(baseMovie.Overview) && // Filter by description
                        _context.Set<Rating>()
                            .Where(r => r.MovieId == m.MovieId)
                            .Average(r => r.RatingValue) >= query.MinRating && // Filter by ratings
                        m.MovieId != baseMovie.MovieId) // Exclude the base movie
                    .OrderByDescending(m => _context.Ratings
                        .Where(r => r.MovieId == m.MovieId)
                        .Average(r => r.RatingValue))
                    .Take(query.MaxResults > 0 ? query.MaxResults : 10)
                    .ToListAsync();

                recommendedMovies.AddRange(movies);
            }

            return recommendedMovies;
        }


        private async Task<List<MovieMetadata>> GetGenreBasedRecommendationsAsync(MovieQueryModel query)
        {
            // Assuming genres are stored in a separate table and associated with movies using MovieId
            var genreBasedMovies = await _context.Set<Genre>()
                .Where(g => g.Name == query.Genre)
                .Select(g => g.MovieId)
                .ToListAsync();

            var genreBasedRecommendations = await _context.Set<MovieMetadata>()
                .Where(m => genreBasedMovies.Contains(m.MovieId))
                .OrderByDescending(m => _context.Set<Rating>()
                    .Where(r => r.MovieId == m.MovieId)
                    .Average(r => r.RatingValue))
                .Take(query.MaxResults > 0 ? query.MaxResults : 10)
                .ToListAsync();

            return genreBasedRecommendations;
        }





    }
}
