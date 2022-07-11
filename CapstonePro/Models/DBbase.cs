using Microsoft.EntityFrameworkCore;

namespace CapstonePro.Models
{
    public class DBbase : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<RequestLine> RequestLines { get; set; }


        public DBbase()
        {

        }

        public DBbase(DbContextOptions<DBbase> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RequestLine>()
                        .Property(b => b.Quantity)
                        .HasDefaultValue(1);

        }



    }
}

