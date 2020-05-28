using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Entities
{
    public class Prescription
    {
        // PK
        public int IdPrescription { get; set; }
        public DateTime Date { get; set; }
        public DateTime DueDate { get; set; }

        // FK
        public int IdDoctor { get; set; }

        // FK
        public int IdPatient { get; set; }


        //Every prescription will have one doctor , one patient and a list of Prescription_medicaments
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
        public  ICollection<Prescription_Medicament> Prescription_Medicaments { get; set; }
    }
}
