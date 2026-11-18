using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Workshop.Domain.Features.Product;
using Workshop.Domain.Features.UserAccounts;
using Workshop.Infrastructure.Features.UserAccounts;

namespace Workshop.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUserEntity, IdentityRole<int>, int> 
        {
        public DbSet<ProductEntity> Products { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProductEntity>(entity => {
                entity.HasKey(k => k.Id);
                entity.Property(p => p.Name).IsRequired().HasMaxLength(100);
                entity.Property(p => p.Price).IsRequired().HasPrecision(18, 2);
                entity.Property(p => p.Stock).IsRequired();
                entity.Property(p => p.CreatedAt).IsRequired();
            });

            modelBuilder.Entity<ApplicationUserEntity>(entity => {
                entity.Property(u => u.Name).IsRequired().HasMaxLength(100);
                entity.Property(u => u.LastName).IsRequired().HasMaxLength(100);
                entity.Property(u => u.CreatedAt).IsRequired();

                entity.HasIndex(u => u.NormalizedEmail).IsUnique();
            });
        }
    }
}
