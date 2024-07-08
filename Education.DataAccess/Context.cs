using Education.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Education.DataAccess
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
           : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Group>()
                .HasMany(s => s.Students)
                .WithOne(g => g.Group)
                .HasForeignKey(g => g.GroupId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
