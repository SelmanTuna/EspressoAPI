using EspressoAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EspressoAPI.Data
{
    public class ExpressoDbContext : DbContext
    {

        public ExpressoDbContext(DbContextOptions<ExpressoDbContext>options):base(options)
        {                
        }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
    }
}
