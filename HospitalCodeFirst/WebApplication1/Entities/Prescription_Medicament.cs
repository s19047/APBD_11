using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Entities
{
	public class Prescription_Medicament
	{
		//FK + PK
		public int IdMedicament { get; set; }

		//FK + PK
		public int IdPrescription { get; set; }

		// nullable
		public Nullable<int> Dose { get; set; }
		public string Details { get; set; }


		// One medicament that is connected to one prescription 
		public  Medicament Medicament { get; set; }
		public  Prescription Prescription { get; set; }

	}
}
