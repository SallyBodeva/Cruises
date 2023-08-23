using Cruises.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace Cruises.Data
{
    public class AppDbContext:DbContext
    {
        private const string connectionString= @"Server=DESKTOP-0FTTVGR; Initial Catalog=Cruises; Integrated Security=true; Trusted_Connection =true";
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<CrewMember> CrewMembers { get; set; }
        public virtual DbSet<Harbour> Harbours { get; set; }
        public virtual DbSet<Passenger> Passengers { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<Ship> Ships { get; set; }
        public virtual DbSet<ShipCrewMember> ShipCrewMembers { get; set; }
        public virtual DbSet<ShipType> ShipTypes { get; set; }
        public virtual DbSet<Voyage> Voyages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connectionString);
            }
            optionsBuilder.UseLazyLoadingProxies();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ShipCrewMember>(option =>
            {
                option.HasKey(x => new { x.ShipId, x.CrewMemberId });
            });


            modelBuilder.Entity<Ship>(option =>
            {
                option.HasIndex(x => x.Name).IsUnique(true);
            });

            modelBuilder.Entity<Harbour>(option =>
            {
                option.HasIndex(x => x.Name).IsUnique(true);
            });

            modelBuilder.Entity<Passenger>(option =>
            {
                option.HasIndex(x => x.PhoneNumber).IsUnique(true);
            });

            modelBuilder.Entity<ShipType>(option =>
            {
                option.HasIndex(x => x.Name).IsUnique(true);
            });

            modelBuilder.Entity<Passenger>()
               .HasMany(r => r.Reservations)
               .WithOne(p => p.Passenger)
               .HasForeignKey(r => r.PassengerId)
               .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CrewMember>()
                .HasMany(scm => scm.ShipCrewMembers)
                .WithOne(s => s.CrewMember)
                .HasForeignKey(s => s.CrewMemberId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Voyage>
                (
                        option =>
                        {
                            option
                        .HasOne(h => h.Harbour)
                        .WithMany(p => p.Harbours)
                        .HasForeignKey(x => x.HarbourId)
                        .OnDelete(DeleteBehavior.NoAction);

                            option
                    .HasOne(p => p.DestinationHarbour)
                    .WithMany(p => p.DestinationHarbours)
                    .HasForeignKey(x => x.DestinationHarbourId)
                    .OnDelete(DeleteBehavior.NoAction);
                        }

                );
        }

    }
}
