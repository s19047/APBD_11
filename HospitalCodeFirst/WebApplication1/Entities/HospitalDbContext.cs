using HospitalDB.Configuration;
using HospitalDB.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Entities
{
    public class HospitalDbContext: DbContext
    {
        public HospitalDbContext(DbContextOptions options) : base(options)
        {

        }

        public HospitalDbContext()
        {

        }

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Medicament> Medicaments { get; set; }
        public DbSet<Prescription_Medicament> Prescription_Medicaments { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Configuration can be found in configuration folder 
            modelBuilder.ApplyConfiguration(new DoctorConfig());
            modelBuilder.ApplyConfiguration(new PatientConfig());
            modelBuilder.ApplyConfiguration(new PrescriptionConfig());
            modelBuilder.ApplyConfiguration(new MedicamentConfig());
            modelBuilder.ApplyConfiguration(new Prescription_MedicamentConfig());

            //Seed Data
            modelBuilder.Seed();
        }
    }
}
