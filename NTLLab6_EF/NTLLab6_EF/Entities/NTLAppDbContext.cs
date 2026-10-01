using Microsoft.EntityFrameworkCore;
using NTLLab6_EF.Models;

namespace NTLLab6_EF.Entities
{
    public class NTLAppDbContext: DbContext
    {
        public NTLAppDbContext(DbContextOptions<NTLAppDbContext> options) : base(options) { }
        public DbSet<NTLCategory> Categories { get; set; }
        public DbSet<NTLProduct> Products { get; set; } 
    }
}
