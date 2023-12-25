using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RecommendationSystemApi.Models
{
    public class SpokenLanguage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DbId { get; set; } // Unique identifier for each record in the database
        public int MovieId { get; set; } // ID of the movie associated with the spoken language
        public string SpokenLanguagesId { get; set; } // A unique identifier for the spoken language, typically an ISO language code
        public string Name { get; set; } // The full name of the spoken language

        //// Additional methods or properties as needed
        //public MovieMetadata Movie { get; set; }
    }

}
