using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Entities
{
	public class Patient
	{
		//PK
		public int IdPatient { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime Birthdate { get; set; }

		// Every Patient will have a list of prescriptions (that were prescribed to him/her)  ( List might be empty ) 
		public ICollection<Prescription> Prescriptions { get; set; }
	}
}
