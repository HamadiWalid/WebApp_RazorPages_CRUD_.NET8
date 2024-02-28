using Microsoft.EntityFrameworkCore;
using WebApp_RazorPages_.NetCore8.Models;

namespace WebApp_RazorPages_.NetCore8.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Client> Clients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().HasData(
                new Client()
                {
                    Id = 1,
                    Name = "Client1",
                    Address = "Ruisseau",
                    PhoneNumber = "0999999999",
                    Email = "Client1@outlook.fr",
                    Order = "S24 ultra"

                });
        }// if we want to add some record to our database
    }
}
