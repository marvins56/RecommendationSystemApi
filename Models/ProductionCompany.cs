using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RecommendationSystemApi.Models
{
    public class ProductionCompany
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int DbId { get; set; } // Unique identifier for each record in the database
        public int MovieId { get; set; } // ID of the movie or entity associated with the production company
        public int ProductionCompaniesId { get; set; } // Unique identifier for the production company
        public string Name { get; set; } // Name of the production company

        // Additional methods or properties as needed
        //public MovieMetadata Movie { get; set; }
    }

}
