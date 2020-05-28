using HospitalDB.DTOs.Requests;
using HospitalDB.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalDB.NewFolder
{
	public interface IDoctorDbService
	{
		public GetDoctorResponse GetDoctor(int id);
		public IEnumerable<GetDoctorResponse> GetAllDoctors();

		public string DeleteDoctor(int id);
		public string InsertDoctor(InsertDoctorRequest request);
		public string ModifyDoctor(ModifyDoctorRequest request);
	}
}
