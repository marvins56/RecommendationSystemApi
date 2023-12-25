namespace RecommendationSystemApi.Models
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;

    public class Rating
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int DbId { get; set; } // Unique identifier for each record in the database

        public int UserId { get; set; } // Identifier for the user who gave the rating
        public int MovieId { get; set; } // Identifier for the movie that was rated
        public float RatingValue { get; set; } // The rating given by the user
        public long Timestamp { get; set; } // Timestamp when the rating was given

        // You may want to convert the timestamp to a DateTime
        public DateTime RatingDateTime => DateTimeOffset.FromUnixTimeSeconds(Timestamp).DateTime;

        // Additional methods or properties as needed

        //public MovieMetadata Movie { get; set; }
    }

}
