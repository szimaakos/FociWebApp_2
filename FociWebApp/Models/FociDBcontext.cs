using Microsoft.EntityFrameworkCore;

namespace FociWebApp.Models
{
    public class FociDBcontext : DbContext
    {
        public FociDBcontext(DbContextOptions<FociDBcontext> options) : base(options) {
            
        }

        public DbSet<Meccs> Meccsek {  get; set; }
    }
}
