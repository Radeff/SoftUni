using MeTube.Models;
using Microsoft.EntityFrameworkCore;

namespace MeTube.Data
{
    public class MeTubeContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Tube> Tubes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=MeTube_Radeff;Integrated Security=True");
            }

            base.OnConfiguring(optionsBuilder);
        }
    }
}
