using Microsoft.EntityFrameworkCore;
using Sakany.Models;

namespace Sakany.Data
{
    public class SakanyDbContext : DbContext
    {
        public SakanyDbContext(DbContextOptions options) : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Avaliable rooms constraint => avl <= rooms
            modelBuilder.Entity<Property>(entity =>
            {
               
                entity.ToTable(t => t.HasCheckConstraint(
                    "CK_Property_AvailableRooms_Limit",
                    "[AvailableRooms] <= [BedRooms]"
                ));

                
                entity.ToTable(t => t.HasCheckConstraint(
                    "CK_Property_Price_Positive",
                    "[Price] >= 0"
                ));
            });


            // Wishlist: Composite Key
            modelBuilder.Entity<Wishlist>()
                .HasKey(w => new { w.UserID, w.PropertyID });

            modelBuilder.Entity<Wishlist>()
                .HasOne(w => w.User)
                .WithMany(u => u.Wishlists)
                .HasForeignKey(w => w.UserID)
                .OnDelete(DeleteBehavior.Cascade); 

            modelBuilder.Entity<Wishlist>()
                .HasOne(w => w.Property)
                .WithMany() 
                .HasForeignKey(w => w.PropertyID)
                .OnDelete(DeleteBehavior.Cascade);

            // Property_Amenity: Composite Key
            modelBuilder.Entity<Property_Amenity>()
                .HasKey(pa => new { pa.PropertyID, pa.AmenityID });

            // User -> Property (Owner)
            modelBuilder.Entity<Property>()
                .HasOne(p => p.Owner)
                .WithMany(u => u.OwnedProperties)
                .HasForeignKey(p => p.OwnerID)
                .OnDelete(DeleteBehavior.Restrict);

            // User -> Request (Client)
            modelBuilder.Entity<Request>()
                .HasOne(r => r.Client)
                .WithMany(u => u.ClientRequests)
                .HasForeignKey(r => r.ClientID)
                .OnDelete(DeleteBehavior.Restrict);

            // Property -> Request
            modelBuilder.Entity<Request>()
                .HasOne(r => r.Property)
                .WithMany(p => p.Requests)
                .HasForeignKey(r => r.PropertyID)
                .OnDelete(DeleteBehavior.Cascade);

            // User -> Message (Sender & Receiver)
            modelBuilder.Entity<Message>()
                .HasOne(m => m.Sender)
                .WithMany(u => u.SentMessages)
                .HasForeignKey(m => m.SenderID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Message>()
                .HasOne(m => m.Receiver)
                .WithMany(u => u.ReceivedMessages)
                .HasForeignKey(m => m.ReceiverID)
                .OnDelete(DeleteBehavior.Restrict);


            // User -> Review
            modelBuilder.Entity<Review>()
                .HasOne(r => r.Client)
                .WithMany(u => u.Reviews)
                .HasForeignKey(r => r.ClientID)
                .OnDelete(DeleteBehavior.Restrict);

            // Property -> Review
            modelBuilder.Entity<Review>()
                .HasOne(r => r.Property)
                .WithMany(p => p.Reviews)
                .HasForeignKey(r => r.PropertyID)
                .OnDelete(DeleteBehavior.Cascade);

            // User -> Notification
            modelBuilder.Entity<Notification>()
                .HasOne(n => n.User)
                .WithMany(u => u.Notifications)
                .HasForeignKey(n => n.UserID)
                .OnDelete(DeleteBehavior.Cascade);

            // Reporter (User) -> Report
            modelBuilder.Entity<Report>()
                .HasOne(r => r.Reporter)
                .WithMany(u => u.Reports)
                .HasForeignKey(r => r.ReporterID)
                .OnDelete(DeleteBehavior.Restrict);

            // Property -> Report
            modelBuilder.Entity<Report>()
                .HasOne(r => r.Property)
                .WithMany() 
                .HasForeignKey(r => r.PropertyID)
                .OnDelete(DeleteBehavior.Cascade);

            // Request -> Review (1 to 1)
            modelBuilder.Entity<Review>()
                .HasOne(r => r.Request)
                .WithOne(req => req.Review)
                .HasForeignKey<Review>(r => r.RequestID)
                .OnDelete(DeleteBehavior.Restrict);

            // Request -> Contract
            modelBuilder.Entity<Contract>()
                .HasOne(c => c.Request)
                .WithOne(req => req.Contract)
                .HasForeignKey<Contract>(c => c.RequestID)
                .OnDelete(DeleteBehavior.Restrict);

            // Owner (User) -> Contract
            modelBuilder.Entity<Contract>()
                .HasOne(c => c.Owner)
                .WithMany(u => u.OwnerContracts)
                .HasForeignKey(c => c.OwnerID)
                .OnDelete(DeleteBehavior.Restrict);

            // Tenant (User) -> Contract
            modelBuilder.Entity<Contract>()
                .HasOne(c => c.Tenant)
                .WithMany(u => u.TenantContracts)
                .HasForeignKey(c => c.TenantID)
                .OnDelete(DeleteBehavior.Restrict);

            // Wishlist Relationships
            modelBuilder.Entity<Wishlist>()
                .HasOne(w => w.User)
                .WithMany(u => u.Wishlists) 
                .HasForeignKey(w => w.UserID);

            modelBuilder.Entity<Wishlist>()
                .HasOne(w => w.Property)
                .WithMany() 
                .HasForeignKey(w => w.PropertyID);

            modelBuilder.Entity<Property_Amenity>()
                .HasKey(pa => new { pa.PropertyID, pa.AmenityID });

            modelBuilder.Entity<Property_Amenity>()
                .HasOne(pa => pa.Property)
                .WithMany(p => p.PropertyAmenity) 
                .HasForeignKey(pa => pa.PropertyID);

            modelBuilder.Entity<Property_Amenity>()
                .HasOne(pa => pa.Amenity)
                .WithMany(a => a.Property_Amenity) 
                .HasForeignKey(pa => pa.AmenityID);

            modelBuilder.Entity<Request>()
                .Property(r => r.Date)
                .HasDefaultValueSql("GETDATE()");

           
            modelBuilder.Entity<Request>()
                .HasIndex(r => new { r.ClientID, r.PropertyID })
                .HasFilter("[Status] = 0")
                .IsUnique();

        }
        public DbSet<User> User { get; set; }
        public DbSet<Property> Property { get; set; }
        public DbSet<PropertyImage> PropertyImage { get; set; }
        public DbSet<Wishlist> Wishlist { get; set; }
        public DbSet<Request> Request { get; set; }
        public DbSet<Review> Review { get; set; }
        public DbSet<Message> Message { get; set; }
        public DbSet<Amenity> Amenity { get; set; }
        public DbSet<Property_Amenity> PropertyAmenity { get; set; }
        public DbSet<Notification> Notification { get; set; }
        public DbSet<Contract> Contract { get; set; }
        public DbSet<Report> Report { get; set; }

    }
}
