using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RecommendationSystemApi.Models
{
    public class ExpandedKeyword
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RecordId { get; set; } // Unique identifier for each record in the dataset
        public int MovieId { get; set; } // ID of the entity (e.g., movie, book) associated with the keyword
        public int KeywordId { get; set; } // Unique identifier for the keyword
        public string Name { get; set; } // Name of the keyword
        //public MovieMetadata Movie { get; set; }

        // Additional methods or properties as needed
    }

}
