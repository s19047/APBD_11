using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entities;

namespace HospitalDB.Configuration
{
	public class MedicamentConfig : IEntityTypeConfiguration<Medicament>
	{
		public void Configure(EntityTypeBuilder<Medicament> builder)
        {
            builder.HasKey(e => e.IdMedicament);
            builder.Property(e => e.IdMedicament).ValueGeneratedOnAdd();
            builder.Property(e => e.Name).HasMaxLength(100).IsRequired();
            builder.Property(e => e.Description).HasMaxLength(100).IsRequired();
            builder.Property(e => e.Type).HasMaxLength(100).IsRequired();
            builder.ToTable("Medicament");

            builder.HasMany(medicament => medicament.Prescription_Medicaments)
                   .WithOne(prescMed => prescMed.Medicament)
                   .HasForeignKey(prescMed => prescMed.IdMedicament)
                   .IsRequired();

        }
    }

}
