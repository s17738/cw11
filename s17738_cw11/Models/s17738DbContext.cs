using System;
using Microsoft.EntityFrameworkCore;

namespace s17738_cw11.Models
{
    public class S17738DbContext : DbContext
    {
        public S17738DbContext()
        {
        }

        public S17738DbContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<Patient> Patients { get; set; }

        public DbSet<Medicament> Medicaments { get; set; }

        public DbSet<Prescription> Prescriptions { get; set; }

        public DbSet<PrescriptionMedicament> PrescriptionMedicaments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctor>(entity =>
            {
                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Birthdate)
                    .IsRequired();
            });

            modelBuilder.Entity<Medicament>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Prescription>(entity =>
            {
                entity.Property(e => e.Date)
                    .IsRequired();

                entity.Property(e => e.DueDate)
                    .IsRequired();

                entity.Property(e => e.IdPatient)
                    .IsRequired();

                entity.Property(e => e.IdDoctor)
                    .IsRequired();
            });

            modelBuilder.Entity<PrescriptionMedicament>(entity =>
            {
                entity.HasKey(e => new { e.IdPrescription, e.IdMedicament });

                entity.Property(e => e.Details)
                    .HasMaxLength(100)
                    .IsRequired();
            });
        }
    }
}
