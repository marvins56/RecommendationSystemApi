using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RecommendationSystemApi.Models
{
    public class MovieLink
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DbId { get; set; } // Unique identifier for each record in the database
        public double MovieId { get; set; } // The internal movie ID, which seems to allow decimal values
        public string ImdbId { get; set; } // The IMDb ID, typically starts with 'tt' followed by a number
        public int TmdbId { get; set; } // The TMDb ID, which is a numeric value
        //public MovieMetadata Movie { get; set; }
        // Additional methods or properties as needed
    }

}
