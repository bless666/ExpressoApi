using Microsoft.EntityFrameworkCore;
using ExpressoApi.Models;

namespace ExpressoApi.Data
{
    public class ExpressDBcontext : DbContext
    {
        public ExpressDBcontext(DbContextOptions<ExpressDBcontext> options) : base(options)
        {

        }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
    }
}
