using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecommendationSystemApi.Models
{
    public class ProductionCountry
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int DbId { get; set; } // Unique identifier for each record in the database
        public int MovieId { get; set; } // ID of the movie associated with the production country
        public string ProductionCountriesId { get; set; } // A unique identifier for the production country, typically an ISO country code
        public string Name { get; set; } // The full name of the production country

        // Additional methods or properties as needed

        //public MovieMetadata Movie { get; set; }
    }

}
