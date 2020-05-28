using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entities;

namespace HospitalDB.Configuration
{
	public class PrescriptionConfig : IEntityTypeConfiguration<Prescription>
	{
		public void Configure(EntityTypeBuilder<Prescription> builder)
		{

            builder.HasKey(e => e.IdPrescription);
            builder.Property(e => e.IdPrescription).ValueGeneratedOnAdd();

            builder.Property(e => e.Date).IsRequired();
            builder.Property(e => e.DueDate).IsRequired();
            builder.Property(e => e.IdPatient).IsRequired();
            builder.Property(e => e.IdDoctor).IsRequired();
            builder.ToTable("Prescription");

            builder.HasMany(prescription => prescription.Prescription_Medicaments)
                   .WithOne(prescMed => prescMed.Prescription)
                   .HasForeignKey(prescMed => prescMed.IdPrescription)
                   .IsRequired();


        }
    }
}
