using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecommendationSystemApi.Models
{
    public class Collection
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public double CollectionId { get; set; }
        public string CollectionName { get; set; }
        public string PosterPath { get; set; }
        public string BackdropPath { get; set; }

        // Additional methods or properties as needed
    }

}
