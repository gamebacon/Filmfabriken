using FilmFabriken.Model.MovieStuff;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FilmFabriken.Model
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Movie>()
                .HasOne(m => m.MovieList)
                .WithMany(ml => ml.Movies)
                .HasForeignKey(m => m.MovieListId);
            
            base.OnModelCreating(builder);
        }


        public DbSet<User.User> User { get; set; }
        public DbSet<MovieList> MovieList { get; set; }
        public DbSet<Movie> Movie { get; set; }
        
    }
}