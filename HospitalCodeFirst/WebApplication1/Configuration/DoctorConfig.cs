using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entities;

namespace HospitalDB.Configuration
{
	public class DoctorConfig : IEntityTypeConfiguration<Doctor>
	{
		public void Configure(EntityTypeBuilder<Doctor> builder)
		{
            
            builder.HasKey(e => e.IdDoctor);
            builder.Property(e => e.IdDoctor).ValueGeneratedOnAdd();
            builder.Property(e => e.FirstName).HasMaxLength(100).IsRequired();
            builder.Property(e => e.LastName).HasMaxLength(100).IsRequired();
            builder.Property(e => e.Email).HasMaxLength(100).IsRequired();
            builder.ToTable("Doctor");

            builder.HasMany(doctor => doctor.Prescriptions)
                      .WithOne(prescription => prescription.Doctor)
                      .HasForeignKey(prescription => prescription.IdDoctor)
                      .IsRequired();
           
        }
	}
}
