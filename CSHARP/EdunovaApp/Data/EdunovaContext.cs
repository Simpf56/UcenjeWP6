using EdunovaAPP.Models;
using Microsoft.EntityFrameworkCore;


namespace EdunovaAPP.Data
{
    public class EdunovaContext : DbContext
    {

        public EdunovaContext(DbContextOptions<EdunovaContext> options) : base(options)
        {
            // ovdje bi upravljali sa razlicitim opcijama, za sada nista

        }

        public DbSet <Smjer> Smjerovi { get; set; }












    }
}
