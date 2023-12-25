namespace RecommendationSystemApi.Data
{
    using Microsoft.EntityFrameworkCore;
    using RecommendationSystemApi.Models;


    public class RSDBContext : DbContext
    {
        public RSDBContext(DbContextOptions<RSDBContext> options)
         : base(options)
        {
        }
        public DbSet<MovieMetadata> MoviesMetadata { get; set; }
        public DbSet<ProductionCompany> ProductionCompanies { get; set; }
        public DbSet<ProductionCountry> ProductionCountries { get; set; }
        public DbSet<RatingSmall> RatingsSmall { get; set; }
         public DbSet<Rating> Ratings { get; set; }
        public DbSet<ExpandedKeyword> ExpandedKeywords { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<MovieLink> MovieLinks { get; set; }
        public DbSet<MovieLinksSmall> MovieLinksSmall { get; set; }
        public DbSet<SpokenLanguage> SpokenLanguages { get; set; }
 
        public DbSet<CreditsCrew> CreditsCrew { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //// MovieMetadata to Rating (One-to-Many)
            //modelBuilder.Entity<MovieMetadata>()
            //    .HasMany(m => m.Ratings)
            //    .WithOne(r => r.Movie)
            //    .HasForeignKey(r => r.MovieId);

            //// MovieMetadata to SpokenLanguage (One-to-Many)
            //modelBuilder.Entity<MovieMetadata>()
            //    .HasMany(m => m.SpokenLanguages)
            //    .WithOne(sl => sl.Movie)
            //    .HasForeignKey(sl => sl.MovieId);

            //// MovieMetadata to ProductionCountry (One-to-Many)
            //modelBuilder.Entity<MovieMetadata>()
            //    .HasMany(m => m.ProductionCountries)
            //    .WithOne(pc => pc.Movie)
            //    .HasForeignKey(pc => pc.MovieId);

            //// MovieMetadata to ProductionCompany (One-to-Many)
            //modelBuilder.Entity<MovieMetadata>()
            //    .HasMany(m => m.ProductionCompanies)
            //    .WithOne(pc => pc.Movie)
            //    .HasForeignKey(pc => pc.MovieId);

            //// MovieMetadata to Genre (One-to-Many)
            //modelBuilder.Entity<MovieMetadata>()
            //    .HasMany(m => m.Genres)
            //    .WithOne(g => g.Movie)
            //    .HasForeignKey(g => g.MovieId);

            //// MovieMetadata to ExpandedKeyword (One-to-Many)
            //modelBuilder.Entity<MovieMetadata>()
            //    .HasMany(m => m.Keywords)
            //    .WithOne(k => k.Movie)
            //    .HasForeignKey(k => k.MovieId);

            ////// MovieMetadata to CreditsCrew (One-to-Many)
            ////modelBuilder.Entity<MovieMetadata>()
            ////    .HasMany(m => m.CreditsCrew)
            ////    .WithOne(cc => cc.Movie)
            ////    .HasForeignKey(cc => cc.MovieId);


            //// Specify other relationships here

            base.OnModelCreating(modelBuilder);
        }
    }

}
