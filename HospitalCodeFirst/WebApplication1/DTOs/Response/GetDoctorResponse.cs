using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalDB.DTOs.Response
{
	public class GetDoctorResponse
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
	}
}
