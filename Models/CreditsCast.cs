using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RecommendationSystemApi.Models
{
    public class CreditsCast

    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int CastId { get; set; }
        public string Character { get; set; }
        public string CreditId { get; set; }
        public int Gender { get; set; } // Assuming 1 for female, 2 for male, 0 for unspecified
        public string Name { get; set; }
        public int Order { get; set; } // Order of appearance or importance
        public string ProfilePath { get; set; } // URL or path to the profile image
        public int MovieId { get; set; } // The ID of the movie they are associated with
        //public MovieMetadata Movie { get; set; }

    }

}
