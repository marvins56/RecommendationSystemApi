namespace RecommendationSystemApi.DTO.payloads
{
    // MovieQueryModel.cs
    public class MovieQueryModel
    {
        public string MovieName { get; set; }
        public string Genre { get; set; }
        public string Keyword { get; set; }
        public double MinRating { get; set; }
        public int MaxResults { get; set; }
    }

}
