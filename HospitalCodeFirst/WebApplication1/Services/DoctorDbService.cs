using HospitalDB.DTOs.Requests;
using HospitalDB.DTOs.Response;
using HospitalDB.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entities;

namespace HospitalDB.Services
{
	public class DoctorDbService : IDoctorDbService
	{
		private readonly HospitalDbContext _context;

		public DoctorDbService(HospitalDbContext context)
		{
			_context = context;
		}

		public IEnumerable<GetDoctorResponse> GetAllDoctors()
		{
			if (!_context.Doctors.Any())
			{
				return null;
			}

			List<GetDoctorResponse> responseList = new List<GetDoctorResponse>();
			foreach (Doctor d in _context.Doctors)
			{
				var response = new GetDoctorResponse
				{
					FirstName = d.FirstName,
					LastName = d.LastName,
					Email = d.Email
				};
				responseList.Add(response);
			}

			return responseList;
		}

		public GetDoctorResponse GetDoctor(int id)
		{
			if (!_context.Doctors.Any())
			{
				return null;
			}

			var doc = _context.Doctors.Where(d => d.IdDoctor.Equals(id)).FirstOrDefault();
			var response = new GetDoctorResponse
			{
				FirstName = doc.FirstName,
				LastName = doc.LastName,
				Email = doc.Email
			};

			return response;
		}


		public string InsertDoctor(InsertDoctorRequest request)
		{
			try
			{
				var doc = new Doctor
				{
					FirstName = request.FirstName,
					LastName = request.LastName,
					Email = request.Email
				};

				_context.Doctors.Add(doc);
				_context.SaveChanges();

				return "Doctor with FirstName: " + doc.FirstName + " and LastName: " + doc.LastName + " has been successfully inserted!";

			}catch(Exception e)
			{
				return null;
			}
		}

		public string ModifyDoctor(ModifyDoctorRequest request)
		{
			try
			{
				var prevDoc = _context.Doctors.Where(d => d.IdDoctor.Equals(request.Id)).FirstOrDefault();

				prevDoc.FirstName = request.FirstName;
				prevDoc.LastName = request.LastName;
				prevDoc.Email = request.Email;

				_context.Doctors.Update(prevDoc);
				_context.SaveChanges();

				return "Doctor with id: " + request.Id + " has been successfully Modified!";
			}
			catch (Exception e)
			{
				return null;
			}
		}


		public string DeleteDoctor(int id)
		{
			var doc = _context.Doctors.Where(d => d.IdDoctor.Equals(id)).FirstOrDefault();
			_context.Doctors.Remove(doc);
			_context.SaveChanges();

			return "Doctor with id : " + id + " has been successfullt removed";

		}
	}
}
