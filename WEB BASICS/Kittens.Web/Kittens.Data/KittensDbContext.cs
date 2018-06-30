using Kittens.Models;
using Microsoft.EntityFrameworkCore;

namespace Kittens.Data
{
    public class KittensDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Kitten> Kittens { get; set; }

        public DbSet<Breed> Breeds { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=Kittens_Radeff;Integrated Security=True");
            }

            base.OnConfiguring(optionsBuilder);
        }
    }
}
