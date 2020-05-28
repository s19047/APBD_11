using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entities;

namespace HospitalDB.Entities
{

    // *IMPORTANT* This class is no longer used since I thought ModelBuilderExtension way was more suitable for this tutorial
    public class HospitalDbInitializer
    {
        public static void Initialize(HospitalDbContext context)
        {
            context.Database.EnsureCreated();

           // Look for any Doctors.
            if (context.Doctors.Any())
            {
                return;   // DB has been seeded
            }

            var mockDoc = new List<Doctor>();
            mockDoc.Add(new Doctor { IdDoctor = 1, FirstName = "Ahmad", LastName = "Alaziz", Email = "s19047@pjwstk.edu.pl" });
            mockDoc.Add(new Doctor { IdDoctor = 2, FirstName = "Alice", LastName = "Lashuk", Email = "AliceLashuk@gmail.com" });
            mockDoc.Add(new Doctor { IdDoctor = 3, FirstName = "Roman", LastName = "Isianko", Email = "Roma@gmail.com" });

            foreach (Doctor d in mockDoc)
            {
                context.Doctors.Add(d);
            }

            context.SaveChanges();

            var mockPatient = new List<Patient>();
            mockPatient.Add(new Patient { IdPatient = 1, FirstName = "Max", LastName = "Alaziz", Birthdate = new DateTime(2000,1,2) });
            mockPatient.Add(new Patient { IdPatient = 2, FirstName = "Connor", LastName = "Lashuk", Birthdate = new DateTime(1982, 1, 2) });
            mockPatient.Add(new Patient { IdPatient = 3, FirstName = "Khabib", LastName = "Isianko", Birthdate = new DateTime(1977, 1, 2) });

            foreach (Patient p in mockPatient)
            {
                context.Patients.Add(p);
            }

            context.SaveChanges();

            var mockPrescription = new List<Prescription>();
            mockPrescription.Add(new Prescription { IdPrescription = 1, Date = new DateTime(1999, 2, 11), DueDate = new DateTime(2002, 2, 11), IdPatient = 3, IdDoctor = 1 });
            mockPrescription.Add(new Prescription { IdPrescription = 2, Date = new DateTime(1967, 3, 12), DueDate = new DateTime(2002, 2, 11), IdPatient = 2, IdDoctor = 2 });
            mockPrescription.Add(new Prescription { IdPrescription = 3, Date = new DateTime(1996, 4, 24), DueDate = new DateTime(2002, 2, 11), IdPatient = 1, IdDoctor = 3 });

            foreach (Prescription p in mockPrescription)
            {
                context.Prescriptions.Add(p);
            }

            context.SaveChanges();

            var mockMedicament = new List<Medicament>();
            mockMedicament.Add(new Medicament { IdMedicament = 1, Name = "Med1", Description = "Alaziz", Type = "KushKush" });
            mockMedicament.Add(new Medicament { IdMedicament = 2, Name = "Med2", Description = "Lashuk", Type = "SmokeTillYouDrop" });
            mockMedicament.Add(new Medicament { IdMedicament = 3, Name = "Med3", Description = "Isianko", Type = "420" });

            foreach (Medicament m in mockMedicament)
            {
                context.Medicaments.Add(m);
            }

            context.SaveChanges();

            var mockPrescMed = new List<Prescription_Medicament>();
            mockPrescMed.Add(new Prescription_Medicament { IdMedicament = 1, IdPrescription = 1, Dose = 31, Details = "ksdlsd" });
            mockPrescMed.Add(new Prescription_Medicament { IdMedicament = 2, IdPrescription = 2, Dose = 23, Details = "wedfwef" });
            mockPrescMed.Add(new Prescription_Medicament { IdMedicament = 3, IdPrescription = 2, Dose = 45, Details = "swefwe" });

            foreach (Prescription_Medicament pm in mockPrescMed)
            {
                context.Prescription_Medicaments.Add(pm);
            }

            context.SaveChanges();
        }

    }
}
