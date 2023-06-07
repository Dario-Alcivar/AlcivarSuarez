using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;    

namespace AlcivarSuarez.Models
{
    public class AplicationDbContext: DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options): base(options) { }
        public DbSet<Usuario> usuarios { get; set; }
    }
}
