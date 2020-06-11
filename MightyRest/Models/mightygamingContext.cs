using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MightyRest.Models
{
    public partial class mightygamingContext : DbContext
    {
        public mightygamingContext()
        {
        }

        public mightygamingContext(DbContextOptions<mightygamingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Assignments> Assignments { get; set; }
        public virtual DbSet<Booking> Booking { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Equipment> Equipment { get; set; }
        public virtual DbSet<Extras> Extras { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<Station> Station { get; set; }
        public virtual DbSet<StationsBookings> StationsBookings { get; set; }
        public virtual DbSet<StationsEquipment> StationsEquipment { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Database=mighty-gaming;Username=postgres;Password=Mighty;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Assignments>(entity =>
            {
                entity.HasKey(e => e.Idassignments)
                    .HasName("assignments_pk");

                entity.ToTable("assignments");

                entity.Property(e => e.Idassignments)
                    .HasColumnName("idassignments")
                    .ValueGeneratedNever();

                entity.Property(e => e.BookingIdbooking).HasColumnName("booking_idbooking");

                entity.Property(e => e.EmployeeIdemployee).HasColumnName("employee_idemployee");

                entity.HasOne(d => d.BookingIdbookingNavigation)
                    .WithMany(p => p.Assignments)
                    .HasForeignKey(d => d.BookingIdbooking)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("assignments_booking");

                entity.HasOne(d => d.EmployeeIdemployeeNavigation)
                    .WithMany(p => p.Assignments)
                    .HasForeignKey(d => d.EmployeeIdemployee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("assignments_employee");
            });

            modelBuilder.Entity<Booking>(entity =>
            {
                entity.HasKey(e => e.Idbooking)
                    .HasName("booking_pk");

                entity.ToTable("booking");

                entity.Property(e => e.Idbooking)
                    .HasColumnName("idbooking")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cost)
                    .HasColumnName("cost")
                    .HasColumnType("numeric(5,2)");

                entity.Property(e => e.CustomerIdcustomer).HasColumnName("customer_idcustomer");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.Hour)
                    .HasColumnName("hour")
                    .HasColumnType("time without time zone");

                entity.Property(e => e.Notes)
                    .IsRequired()
                    .HasColumnName("notes")
                    .HasMaxLength(255);

                entity.Property(e => e.Numberofpeople).HasColumnName("numberofpeople");

                entity.Property(e => e.Opinion).HasColumnName("opinion");

                entity.Property(e => e.Requiredemployees).HasColumnName("requiredemployees");

                entity.HasOne(d => d.CustomerIdcustomerNavigation)
                    .WithMany(p => p.Booking)
                    .HasForeignKey(d => d.CustomerIdcustomer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("booking_customer");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.Idcustomer)
                    .HasName("customer_pk");

                entity.ToTable("customer");

                entity.Property(e => e.Idcustomer)
                    .HasColumnName("idcustomer")
                    .ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(50);

                entity.Property(e => e.PersonIdperson).HasColumnName("person_idperson");

                entity.Property(e => e.Phonenumber)
                    .IsRequired()
                    .HasColumnName("phonenumber")
                    .HasMaxLength(12);

                entity.HasOne(d => d.PersonIdpersonNavigation)
                    .WithMany(p => p.Customer)
                    .HasForeignKey(d => d.PersonIdperson)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("customer_person");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.Idemployee)
                    .HasName("employee_pk");

                entity.ToTable("employee");

                entity.Property(e => e.Idemployee)
                    .HasColumnName("idemployee")
                    .ValueGeneratedNever();

                entity.Property(e => e.Hiredate)
                    .HasColumnName("hiredate")
                    .HasColumnType("date");

                entity.Property(e => e.PersonIdperson).HasColumnName("person_idperson");

                entity.HasOne(d => d.PersonIdpersonNavigation)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.PersonIdperson)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("employee_person");
            });

            modelBuilder.Entity<Equipment>(entity =>
            {
                entity.HasKey(e => e.Serialnumber)
                    .HasName("equipment_pk");

                entity.ToTable("equipment");

                entity.Property(e => e.Serialnumber)
                    .HasColumnName("serialnumber")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(75);

                entity.Property(e => e.Producent)
                    .IsRequired()
                    .HasColumnName("producent")
                    .HasMaxLength(150);

                entity.Property(e => e.Purchasedate)
                    .HasColumnName("purchasedate")
                    .HasColumnType("date");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(75);

                entity.Property(e => e.Warrantydate)
                    .HasColumnName("warrantydate")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<Extras>(entity =>
            {
                entity.HasKey(e => e.Idextras)
                    .HasName("extras_pk");

                entity.ToTable("extras");

                entity.Property(e => e.Idextras)
                    .HasColumnName("idextras")
                    .ValueGeneratedNever();

                entity.Property(e => e.BookingIdbooking).HasColumnName("booking_idbooking");

                entity.Property(e => e.OrderIdorder).HasColumnName("order_idorder");

                entity.HasOne(d => d.BookingIdbookingNavigation)
                    .WithMany(p => p.Extras)
                    .HasForeignKey(d => d.BookingIdbooking)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("extras_booking");

                entity.HasOne(d => d.OrderIdorderNavigation)
                    .WithMany(p => p.Extras)
                    .HasForeignKey(d => d.OrderIdorder)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("extras_order");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.Idorder)
                    .HasName("order_pk");

                entity.Property(e => e.Idorder)
                    .HasColumnName("idorder")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cost)
                    .HasColumnName("cost")
                    .HasColumnType("numeric(5,2)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(75);
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasKey(e => e.Idperson)
                    .HasName("person_pk");

                entity.ToTable("person");

                entity.Property(e => e.Idperson)
                    .HasColumnName("idperson")
                    .ValueGeneratedNever();

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasColumnName("firstname")
                    .HasMaxLength(75);

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasColumnName("lastname")
                    .HasMaxLength(75);
            });

            modelBuilder.Entity<Station>(entity =>
            {
                entity.HasKey(e => e.Stationnumber)
                    .HasName("station_pk");

                entity.ToTable("station");

                entity.Property(e => e.Stationnumber)
                    .HasColumnName("stationnumber")
                    .ValueGeneratedNever();

                entity.Property(e => e.Inspectiondate)
                    .HasColumnName("inspectiondate")
                    .HasColumnType("date");

                entity.Property(e => e.Specialization)
                    .IsRequired()
                    .HasColumnName("specialization")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<StationsBookings>(entity =>
            {
                entity.ToTable("stations_bookings");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BookingIdbooking).HasColumnName("booking_idbooking");

                entity.Property(e => e.StationStationnumber).HasColumnName("station_stationnumber");

                entity.HasOne(d => d.BookingIdbookingNavigation)
                    .WithMany(p => p.StationsBookings)
                    .HasForeignKey(d => d.BookingIdbooking)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("stations_bookings_booking");

                entity.HasOne(d => d.StationStationnumberNavigation)
                    .WithMany(p => p.StationsBookings)
                    .HasForeignKey(d => d.StationStationnumber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("stations_bookings_station");
            });

            modelBuilder.Entity<StationsEquipment>(entity =>
            {
                entity.ToTable("stations_equipment");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EquipmentSerialnumber).HasColumnName("equipment_serialnumber");

                entity.Property(e => e.StationStationnumber).HasColumnName("station_stationnumber");

                entity.HasOne(d => d.EquipmentSerialnumberNavigation)
                    .WithMany(p => p.StationsEquipment)
                    .HasForeignKey(d => d.EquipmentSerialnumber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("stations_equipment_equipment");

                entity.HasOne(d => d.StationStationnumberNavigation)
                    .WithMany(p => p.StationsEquipment)
                    .HasForeignKey(d => d.StationStationnumber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("stations_equipment_station");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
