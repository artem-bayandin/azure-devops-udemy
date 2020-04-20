using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Data
{
    public interface IMyContext
    {
        DbSet<Product> Products { get; set; }
        DbSet<Person> People { get; set; }
        DbSet<OrderLine> Orders { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }

    public class MyContext : DbContext, IMyContext
    {
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<OrderLine> Orders { get; set; }

        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MyContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
