using Microsoft.EntityFrameworkCore;
using Week12Practice1_CodeFirst.Entities;

namespace Week12Practice1_CodeFirst.Context
{
    public class PatikaFirstDbContext : DbContext
    {
        public PatikaFirstDbContext(DbContextOptions<PatikaFirstDbContext> options) : base(options) 
        {
                
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<MovieEntitiy> Movies => Set<MovieEntitiy>();
        public DbSet<GameEntity> Games => Set<GameEntity>();    
    }
}
