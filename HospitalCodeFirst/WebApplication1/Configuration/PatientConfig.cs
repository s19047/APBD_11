using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entities;

namespace HospitalDB.Configuration
{
	public class PatientConfig : IEntityTypeConfiguration<Patient>
	{
		public void Configure(EntityTypeBuilder<Patient> builder)
		{
            builder.HasKey(e => e.IdPatient);
            builder.Property(e => e.IdPatient).ValueGeneratedOnAdd();
            builder.Property(e => e.FirstName).HasMaxLength(100).IsRequired();
            builder.Property(e => e.LastName).HasMaxLength(100).IsRequired();
            builder.Property(e => e.Birthdate).IsRequired();
            builder.ToTable("Patient");

            builder.HasMany(patient => patient.Prescriptions)
                   .WithOne(prescription => prescription.Patient)
                   .HasForeignKey(prescription => prescription.IdPatient)
                   .IsRequired();

        }
	}
}
