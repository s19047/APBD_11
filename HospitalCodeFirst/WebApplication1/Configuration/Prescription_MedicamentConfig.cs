using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entities;

namespace HospitalDB.Configuration
{
	public class Prescription_MedicamentConfig : IEntityTypeConfiguration<Prescription_Medicament>
	{
		public void Configure(EntityTypeBuilder<Prescription_Medicament> builder)
		{
			//Dose will be nullable
			builder.HasKey(e => new { e.IdMedicament, e.IdPrescription });
			builder.Property(e => e.Dose).IsRequired(false);
			builder.Property(e => e.Details).HasMaxLength(100).IsRequired();

			builder.ToTable("Prescription_Medicament");

		}
	}
}
