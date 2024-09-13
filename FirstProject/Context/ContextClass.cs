using FirstProject.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstProject.Context
{
    public class ContextClass : DbContext
        
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-DTG4NSB;Database=FirstProject;Trusted_Connection=True;Encrypt=false");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure unique index on Email field
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();

            // CategoryId, Name, Description.
            var _Categories = new List<Category>
    {
        new Category { CategoryId = 1, Name = "Books", Description = "A collection of written or printed works" },
        new Category { CategoryId = 2, Name = "NoteBooks", Description = "Books for writing notes" },
        new Category { CategoryId = 3, Name = "Pencils", Description = "Writing instruments made of graphite" },
        new Category { CategoryId = 4, Name = "Colors", Description = "Various coloring materials" },
        new Category { CategoryId = 5, Name = "Colors", Description = "Various coloring materials" },
        new Category { CategoryId = 6, Name = "Colors", Description = "Various coloring materials" },
        new Category { CategoryId = 7, Name = "Colors", Description = "Various coloring materials" },
        new Category { CategoryId = 8, Name = "Colors", Description = "Various coloring materials" },
        new Category { CategoryId = 9, Name = "Colors", Description = "Various coloring materials" },
        new Category { CategoryId = 10, Name = "Colors", Description = "Various coloring materials" },
        new Category { CategoryId = 11, Name = "Colors", Description = "Various coloring materials" },
        new Category { CategoryId = 12, Name = "Colors", Description = "Various coloring materials"},
    };

            var _Products = new List<Product>
    {
        new Product { ProductId = 1, Title = "Books", Price = 1, Description = "qq", Quantity = 1, ImagePath = "books1.jpg",CategoryId=1},
        new Product { ProductId = 2, Title = "Books", Price = 2, Description = "rr", Quantity = 1, ImagePath = "books2.jpg",CategoryId=2 },
        new Product { ProductId = 3, Title = "Story", Price = 3, Description = "rr", Quantity = 1, ImagePath = "story.jpg",CategoryId=3},
        new Product { ProductId = 4, Title = "Paper", Price = 4, Description = "rr", Quantity = 1, ImagePath = "paper1.jpg" ,CategoryId=4},
        new Product { ProductId = 5, Title = "Pince", Price = 5, Description = "rr", Quantity = 2, ImagePath = "pince.jpg",CategoryId=5},
        new Product { ProductId = 6, Title = "Paper", Price = 6, Description = "rr", Quantity = 2, ImagePath = "paper2.jpg" ,CategoryId=6},
        new Product { ProductId = 7, Title = "Color", Price = 7, Description = "rr", Quantity = 2, ImagePath = "color.jpg",CategoryId=7},
        new Product { ProductId = 8, Title = "Books", Price = 8, Description = "rr", Quantity = 2, ImagePath = "books3.jpg" ,CategoryId=8},
        new Product { ProductId = 9, Title = "Paper", Price = 9, Description = "rr", Quantity = 2, ImagePath = "paper3.jpg",CategoryId=9 },
        new Product { ProductId = 10, Title = "Highl", Price = 10, Description = "rr", Quantity = 3, ImagePath = "highl.jpg" , CategoryId = 10},
        new Product { ProductId = 11, Title = "Note", Price = 11, Description = "rr", Quantity = 3, ImagePath = "note.jpg" , CategoryId = 11},
        new Product { ProductId = 12, Title = "Paper", Price = 12, Description = "rr", Quantity = 3, ImagePath = "paper4.jpg" , CategoryId = 12}
    };

            modelBuilder.Entity<Category>().HasData(_Categories);
            modelBuilder.Entity<Product>().HasData(_Products);
        }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<Category> Categories { get; set; }


    }
}
