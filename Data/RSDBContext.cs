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
        public DbSet<CreditsCrew> CastCrew { get; set; }
        public DbSet<CreditsCrew> CreditsCrew { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //      // Configure MovieMetadata entity
            //      modelBuilder.Entity<MovieMetadata>()
            //          .HasKey(m => m.DbId);

            //      // Configure one-to-many relationships
            //      modelBuilder.Entity<MovieMetadata>()
            //          .HasMany(m => m.ProductionCompanies)
            //          .WithOne(pc => pc.MovieMetadata)
            //          .HasForeignKey(pc => pc.MovieId);

            //      modelBuilder.Entity<MovieMetadata>()
            //          .HasMany(m => m.ProductionCountries)
            //          .WithOne(pc => pc.MovieMetadata)
            //          .HasForeignKey(pc => pc.MovieId);

            //      modelBuilder.Entity<MovieMetadata>()
            //          .HasMany(m => m.Genres)
            //          .WithOne(g => g.MovieMetadata)
            //          .HasForeignKey(g => g.MovieId);

            //      modelBuilder.Entity<MovieMetadata>()
            //          .HasMany(m => m.SpokenLanguages)
            //          .WithOne(sl => sl.MovieMetadata)
            //          .HasForeignKey(sl => sl.MovieId);

            //      modelBuilder.Entity<MovieMetadata>()
            //          .HasMany(m => m.ExpandedKeywords)
            //          .WithOne(ek => ek.MovieMetadata)
            //          .HasForeignKey(ek => ek.MovieId);

            //      modelBuilder.Entity<MovieMetadata>()
            //          .HasMany(m => m.CreditsCrew)
            //          .WithOne(cc => cc.MovieMetadata)
            //          .HasForeignKey(cc => cc.MovieId);

            //      modelBuilder.Entity<MovieMetadata>()
            //          .HasMany(m => m.CreditsCrew)
            //          .WithOne(cc => cc.MovieMetadata)
            //          .HasForeignKey(cc => cc.MovieId);

            //      modelBuilder.Entity<MovieMetadata>()
            //          .HasMany(m => m.RatingsSmall)
            //          .WithOne(rs => rs.MovieMetadata)
            //          .HasForeignKey(rs => rs.MovieId);

            //      modelBuilder.Entity<MovieLink>()
            //.HasOne(ml => ml.MovieMetadata)
            //.WithMany(mm => mm.MovieLinks)
            //.HasForeignKey(ml => ml.MovieId); // Ensure types match here


            //      modelBuilder.Entity<MovieMetadata>()
            //          .HasOne(m => m.MovieLinksSmall)
            //          .WithOne(mls => mls.MovieMetadata)
            //          .HasForeignKey<MovieLinksSmall>(mls => mls.MovieId);
            //  }



            // ... Additional context methods and configurations
        }
    }

}
