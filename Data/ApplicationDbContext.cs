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

    }
}
