using Microsoft.EntityFrameworkCore;
using Item.Domain.Entities;
using System.Reflection;

namespace Item.Infrastracture.Db
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<UnitMaster> UnitMasters { get; set; } = null!;
        public DbSet<ItemTypeMaster> ItemTypeMasters { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // 同アセンブリ内の IEntityTypeConfiguration をすべて適用
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }
    }
}
