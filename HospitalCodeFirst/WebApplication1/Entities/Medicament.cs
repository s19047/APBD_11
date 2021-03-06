﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Entities
{
	public class Medicament
	{
		// PK
		public int IdMedicament { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string Type { get; set; }

		//List of Prescription_Medicaments 
		public ICollection<Prescription_Medicament> Prescription_Medicaments { get; set; }
	}
}
