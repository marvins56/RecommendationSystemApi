using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RecommendationSystemApi.Models
{
    public class Genre
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DbId { get; set; } // Unique identifier for each record in the database
        public int MovieId { get; set; } // ID of the entity (e.g., movie) associated with the genre
        public int GenreId { get; set; } // Unique identifier for the genre
        public string Name { get; set; } // Name of the genre
        //public MovieMetadata Movie { get; set; }
    }

    // Additional methods or properties as needed
}


