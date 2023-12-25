namespace RecommendationSystemApi.Models
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;

    public class MovieMetadata
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DbId { get; set; } // Unique identifier for each record in the database

        public bool Adult { get; set; }
        public long Budget { get; set; }
        public string Homepage { get; set; }
       
        public string ImdbId { get; set; }
        public string OriginalLanguage { get; set; }
        public string OriginalTitle { get; set; }
        public string Overview { get; set; }
        public double Popularity { get; set; }
        public string PosterPath { get; set; }
        public DateTime ReleaseDate { get; set; }
        public long Revenue { get; set; }
        public int Runtime { get; set; }
        public string Status { get; set; }
        public string Tagline { get; set; }
        public string Title { get; set; }
        public bool Video { get; set; }
        public double VoteAverage { get; set; }
        public double VoteCount { get; set; }

        public int MovieId { get; set; }

        //// Navigation properties for related entities
        //public List<Rating> Ratings { get; set; }
        //public List<SpokenLanguage> SpokenLanguages { get; set; }
        //public List<ProductionCountry> ProductionCountries { get; set; }
        //public List<ProductionCompany> ProductionCompanies { get; set; }
        //public List<Genre> Genres { get; set; }
        //public List<ExpandedKeyword> Keywords { get; set; }
        //public List<CreditsCrew> CreditsCrew { get; set; }
    }

}
