using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RecommendationSystemApi.Models
{
    public class MovieLinksSmall
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DbId { get; set; } // Unique identifier for each record in the database

        public int MovieId { get; set; } // Internal unique identifier for a movie
        public string ImdbId { get; set; } // The IMDb ID as a string (since it starts with 'tt')
        public int TmdbId { get; set; } // The TMDb ID as an integer
        //public MovieMetadata Movie { get; set; }
    }

}
