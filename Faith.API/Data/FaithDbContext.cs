using Faith.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace Faith.API.Data
{
    public class FaithDbContext:DbContext
    {
        public FaithDbContext(DbContextOptions<FaithDbContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Begeleider>().HasData(new Begeleider
            {
                Id = 1,
                Name = "Arne Verdcourt"
            });
            modelBuilder.Entity<Begeleider>().HasData(new Begeleider
            {
                Id = 2,
                Name = "Tim Verdcourt"
            });
            modelBuilder.Entity<Jongere>().HasData(new Jongere
            {
                Id = 1,
                BegeleiderId = 1,
                Name = "John Doe"
            });
            modelBuilder.Entity<Jongere>().HasData(new Jongere
            {
                Id = 2,
                BegeleiderId = 1,
                Name = "John Doe the second"
            });
            modelBuilder.Entity<Jongere>().HasData(new Jongere
            {
                Id = 3,
                BegeleiderId = 1,
                Name = "John Doe the third"
            });
            modelBuilder.Entity<Jongere>().HasData(new Jongere
            {
                Id = 4,
                BegeleiderId = 1,
                Name = "John Doe the fourth"
            });
            modelBuilder.Entity<Jongere>().HasData(new Jongere
            {
                Id = 5,
                BegeleiderId = 2,
                Name = "Jane Doe"
            });
            modelBuilder.Entity<Jongere>().HasData(new Jongere
            {
                Id = 6,
                BegeleiderId = 2,
                Name = "Jane Doe the second"
            });
            modelBuilder.Entity<Jongere>().HasData(new Jongere
            {
                Id = 7,
                BegeleiderId = 2,
                Name = "Jane Doe the third"
            });
            modelBuilder.Entity<Jongere>().HasData(new Jongere
            {
                Id = 8,
                BegeleiderId = 2,
                Name = "Jane Doe the fourth"
            });
            modelBuilder.Entity<Post>().HasData(new Post
            {
                Id = 1,
                JongereId = 1,
                ImageURL = "",
                TimeStamp = DateTime.Now
            });
            modelBuilder.Entity<Post>().HasData(new Post
            {
                Id = 2,
                JongereId = 1,
                ImageURL = "",
                TimeStamp = DateTime.Now
            });
            modelBuilder.Entity<Post>().HasData(new Post
            {
                Id = 3,
                JongereId = 2,
                ImageURL = "",
                TimeStamp = DateTime.Now
            });
            modelBuilder.Entity<Post>().HasData(new Post
            {
                Id = 4,
                JongereId = 3,
                ImageURL = "",
                TimeStamp = DateTime.Now
            });
            modelBuilder.Entity<Post>().HasData(new Post
            {
                Id = 5,
                JongereId = 4,
                ImageURL = "",
                TimeStamp = DateTime.Now
            });
            modelBuilder.Entity<Post>().HasData(new Post
            {
                Id = 6,
                JongereId = 4,
                ImageURL = "",
                TimeStamp = DateTime.Now
            });
            modelBuilder.Entity<Post>().HasData(new Post
            {
                Id = 7,
                JongereId = 5,
                ImageURL = "",
                TimeStamp = DateTime.Now
            });
            modelBuilder.Entity<Post>().HasData(new Post
            {
                Id = 8,
                JongereId = 6,
                ImageURL = "",
                TimeStamp = DateTime.Now
            });
            modelBuilder.Entity<Post>().HasData(new Post
            {
                Id = 9,
                JongereId = 7,
                ImageURL = "",
                TimeStamp = DateTime.Now
            });
            modelBuilder.Entity<Post>().HasData(new Post
            {
                Id = 10,
                JongereId = 8,
                ImageURL = "",
                TimeStamp = DateTime.Now
            });
            modelBuilder.Entity<Reactie>().HasData(new Reactie
            {
                Id = 1,
                PostId = 1,
                Content = "Testing 1"
            });
            modelBuilder.Entity<Reactie>().HasData(new Reactie
            {
                Id = 2,
                PostId = 2,
                Content = "Testing 2"
            });
            modelBuilder.Entity<Reactie>().HasData(new Reactie
            {
                Id = 3,
                PostId = 2,
                Content = "Testing 3"
            });
            modelBuilder.Entity<Reactie>().HasData(new Reactie
            {
                Id = 4,
                PostId = 4,
                Content = "Testing 4"
            });
            modelBuilder.Entity<Reactie>().HasData(new Reactie
            {
                Id = 5,
                PostId = 4,
                Content = "Testing 5"
            });
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Reactie> Reacties { get; set; }
        public DbSet<Begeleider> Begeleiders { get; set; }
        public DbSet<Jongere> Jongeren { get; set; }
    }
}
