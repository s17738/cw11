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

                entity.HasData(new Doctor { IdDoctor = 1, FirstName = "Adam", LastName = "Nowak", Email = "nowak@ddd.com" });
                entity.HasData(new Doctor { IdDoctor = 2, FirstName = "Jan", LastName = "Kowalski", Email = "kowalski@ddd.com" });
                entity.HasData(new Doctor { IdDoctor = 3, FirstName = "Kasia", LastName = "Nowak", Email = "kasian@ddd.com" });
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

                entity.HasData(new Patient { Idpatient = 1, FirstName = "Marcin", LastName = "Adamczyk", Birthdate = DateTime.Now });
                entity.HasData(new Patient { Idpatient = 2, FirstName = "Tomasz", LastName = "Malinowski", Birthdate = DateTime.Now });
                entity.HasData(new Patient { Idpatient = 3, FirstName = "Monika", LastName = "Domska", Birthdate = DateTime.Now });
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

                entity.HasData(new Medicament { IdMedicament = 1, Name = "Ibuprom", Description = "For headache", Type = "basic" });
                entity.HasData(new Medicament { IdMedicament = 2, Name = "Apap", Description = "For headache", Type = "basic" });
                entity.HasData(new Medicament { IdMedicament = 3, Name = "Nospa", Description = "For headache", Type = "basic" });
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

                entity.HasData(new Prescription { IdPrescription = 1, Date = DateTime.Now, DueDate = DateTime.Now.AddDays(30), IdPatient = 1, IdDoctor = 1 });
                entity.HasData(new Prescription { IdPrescription = 2, Date = DateTime.Now, DueDate = DateTime.Now.AddDays(30), IdPatient = 2, IdDoctor = 2 });
                entity.HasData(new Prescription { IdPrescription = 3, Date = DateTime.Now, DueDate = DateTime.Now.AddDays(30), IdPatient = 3, IdDoctor = 3 });
            });

            modelBuilder.Entity<PrescriptionMedicament>(entity =>
            {
                entity.HasKey(e => new { e.IdPrescription, e.IdMedicament });

                entity.Property(e => e.Details)
                    .HasMaxLength(100)
                    .IsRequired();

                entity.HasData(new PrescriptionMedicament { IdMedicament = 1, IdPrescription = 1, Details = "none" });
                entity.HasData(new PrescriptionMedicament { IdMedicament = 3, IdPrescription = 1, Details = "1x1" });
                entity.HasData(new PrescriptionMedicament { IdMedicament = 1, IdPrescription = 2, Details = "2x2" });
            });
        }
    }
}
