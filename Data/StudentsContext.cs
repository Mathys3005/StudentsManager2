using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StudentsCoursCesi.Models.Entities;

namespace StudentsCoursCesi.Data
{
    public class StudentsContext : IdentityDbContext
    {
        public StudentsContext(DbContextOptions<StudentsContext> options)
            : base(options)
        {
        }

        public DbSet<Students> Students { get; set; }

    }
}
