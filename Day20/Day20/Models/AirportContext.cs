using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Day20.Models
{
    public partial class AirportContext : DbContext
    {
        public AirportContext()
        {
        }

        public AirportContext(DbContextOptions<AirportContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AirLine> AirLines { get; set; } = null!;
        public virtual DbSet<AirportEmp> AirportEmps { get; set; } = null!;
        public virtual DbSet<Baggage> Baggages { get; set; } = null!;
        public virtual DbSet<CheckPoint> CheckPoints { get; set; } = null!;
        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<Flight> Flights { get; set; } = null!;
        public virtual DbSet<Gate> Gates { get; set; } = null!;
        public virtual DbSet<Passenger> Passengers { get; set; } = null!;
        public virtual DbSet<Terminal> Terminals { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=ALEZZ;Database=Airport;Integrated Security=true;TrustServerCertificate=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AirLine>(entity =>
            {
                entity.HasKey(e => e.AirLineNo)
                    .HasName("PK__AirLine__D56E7FA9C33484C0");

                entity.ToTable("AirLine");

                entity.Property(e => e.AirLineNo)
                    .ValueGeneratedNever()
                    .HasColumnName("AirLine_No");

                entity.Property(e => e.AirlineName)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Airline_name");

                entity.Property(e => e.ContactEmail)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("contact_email");

                entity.Property(e => e.ContactNumber).HasColumnName("contact_number");
            });

            modelBuilder.Entity<AirportEmp>(entity =>
            {
                entity.HasKey(e => e.PersonalId)
                    .HasName("PK__Airport___C168A85D99DAE29E");

                entity.ToTable("Airport_Emp");

                entity.Property(e => e.PersonalId)
                    .ValueGeneratedNever()
                    .HasColumnName("personal_ID");

                entity.Property(e => e.ContactEmail)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Contact_Email");

                entity.Property(e => e.ContactNumber).HasColumnName("contact_number");

                entity.Property(e => e.DepartmentId).HasColumnName("Department_ID");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Position)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("position");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.AirportEmps)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK__Airport_E__Depar__4316F928");
            });

            modelBuilder.Entity<Baggage>(entity =>
            {
                entity.HasKey(e => e.BaggId)
                    .HasName("PK__Baggage__842E51497503B948");

                entity.ToTable("Baggage");

                entity.Property(e => e.BaggId)
                    .ValueGeneratedNever()
                    .HasColumnName("Bagg_ID");

                entity.Property(e => e.PassengerId).HasColumnName("passenger_ID");

                entity.Property(e => e.TrackingNumber).HasColumnName("tracking_number");

                entity.Property(e => e.Weigh).HasColumnName("weigh");

                entity.HasOne(d => d.Passenger)
                    .WithMany(p => p.Baggages)
                    .HasForeignKey(d => d.PassengerId)
                    .HasConstraintName("FK__Baggage__passeng__3C69FB99");
            });

            modelBuilder.Entity<CheckPoint>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("check_Point");

                entity.Property(e => e.CheackPointId).HasColumnName("cheack_pointID");

                entity.Property(e => e.Locatio)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PassengerId).HasColumnName("passenger_ID");

                entity.Property(e => e.StaffId).HasColumnName("staff_ID");

                entity.Property(e => e.TerId).HasColumnName("Ter_ID");

                entity.HasOne(d => d.Passenger)
                    .WithMany()
                    .HasForeignKey(d => d.PassengerId)
                    .HasConstraintName("FK__check_Poi__passe__46E78A0C");

                entity.HasOne(d => d.Staff)
                    .WithMany()
                    .HasForeignKey(d => d.StaffId)
                    .HasConstraintName("FK__check_Poi__staff__44FF419A");

                entity.HasOne(d => d.Ter)
                    .WithMany()
                    .HasForeignKey(d => d.TerId)
                    .HasConstraintName("FK__check_Poi__Ter_I__45F365D3");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("Department");

                entity.Property(e => e.DepartmentId)
                    .ValueGeneratedNever()
                    .HasColumnName("Department_ID");

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Department_Name");
            });

            modelBuilder.Entity<Flight>(entity =>
            {
                entity.HasKey(e => e.FlightNo)
                    .HasName("PK__Flight__CAC37208F36D7B8D");

                entity.ToTable("Flight");

                entity.Property(e => e.FlightNo)
                    .ValueGeneratedNever()
                    .HasColumnName("Flight_NO");

                entity.Property(e => e.AirLineNo).HasColumnName("AirLine_No");

                entity.Property(e => e.ArrivalTime).HasColumnName("arrival_time");

                entity.Property(e => e.DepartureCity)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("departure_City");

                entity.Property(e => e.DepartureTime).HasColumnName("departure_time");

                entity.Property(e => e.DestinationCity)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("destination_City");

                entity.Property(e => e.FlightStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("flight_status")
                    .IsFixedLength();

                entity.Property(e => e.GateNo).HasColumnName("Gate_No");

                entity.HasOne(d => d.AirLineNoNavigation)
                    .WithMany(p => p.Flights)
                    .HasForeignKey(d => d.AirLineNo)
                    .HasConstraintName("FK__Flight__AirLine___35BCFE0A");

                entity.HasOne(d => d.GateNoNavigation)
                    .WithMany(p => p.Flights)
                    .HasForeignKey(d => d.GateNo)
                    .HasConstraintName("FK__Flight__Gate_No__36B12243");
            });

            modelBuilder.Entity<Gate>(entity =>
            {
                entity.HasKey(e => e.GateNo)
                    .HasName("PK__Gate__85C3CA4E560634B5");

                entity.ToTable("Gate");

                entity.Property(e => e.GateNo)
                    .ValueGeneratedNever()
                    .HasColumnName("Gate_No");

                entity.Property(e => e.Availabil)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("availabil");

                entity.Property(e => e.GateNumber).HasColumnName("Gate_number");
            });

            modelBuilder.Entity<Passenger>(entity =>
            {
                entity.ToTable("passengers");

                entity.Property(e => e.PassengerId)
                    .ValueGeneratedNever()
                    .HasColumnName("passenger_ID");

                entity.Property(e => e.Capacity).HasColumnName("capacity");

                entity.Property(e => e.ContactEmail)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("contact_email");

                entity.Property(e => e.ContactPhone).HasColumnName("contact_phone");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("First_name");

                entity.Property(e => e.FlightNo).HasColumnName("Flight_NO");

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("gender")
                    .IsFixedLength();

                entity.Property(e => e.LastName)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Last_name");

                entity.Property(e => e.PassengerPasspoertNumber).HasColumnName("passenger_passpoertNumber");

                entity.Property(e => e.YearBirth).HasColumnName("year_birth");

                entity.HasOne(d => d.FlightNoNavigation)
                    .WithMany(p => p.Passengers)
                    .HasForeignKey(d => d.FlightNo)
                    .HasConstraintName("FK__passenger__Fligh__398D8EEE");
            });

            modelBuilder.Entity<Terminal>(entity =>
            {
                entity.HasKey(e => e.TerId)
                    .HasName("PK__Terminal__418E12B9950D950C");

                entity.ToTable("Terminal");

                entity.Property(e => e.TerId)
                    .ValueGeneratedNever()
                    .HasColumnName("Ter_ID");

                entity.Property(e => e.Capcity).HasColumnName("capcity");

                entity.Property(e => e.Locatio)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TerName)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Ter_Name");

                entity.HasOne(d => d.Gate)
                    .WithMany(p => p.Terminals)
                    .HasForeignKey(d => d.GateId)
                    .HasConstraintName("FK_Terminal_Gate");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
