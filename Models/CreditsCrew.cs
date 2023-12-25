using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RecommendationSystemApi.Models
{
    public class CreditsCrew
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DbId { get; set; }
        public int MovieId { get; set; } // The ID of the movie they are associated with
        public string CreditId { get; set; }
        public string Department { get; set; }
        public int Gender { get; set; } // Assuming 1 for female, 2 for male, 0 for unspecified
        public string Job { get; set; }
        public string Name { get; set; }
        public string ProfilePath { get; set; } // URL or path to the profile image
        public int CrewId { get; set; } // Unique identifier for the crew member
    
        
    }

}
