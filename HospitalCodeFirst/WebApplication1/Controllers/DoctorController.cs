using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalDB.DTOs.Requests;
using HospitalDB.NewFolder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Entities;

namespace WebApplication1.Controllers
{
    [Route("api/doctors")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorDbService _service;

        public DoctorController(IDoctorDbService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAllDoctors()
        {
            var res = _service.GetAllDoctors();
            if (!res.Equals(null))
            {
                return Ok(res);
            }
            else
            {
                return BadRequest("Something went wrong :/");
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetDoctor(int id)
        {
            var res = _service.GetDoctor(id);
            if (!res.Equals(null))
            {
                return Ok(res);
            }
            else
            {
                return BadRequest("Something went wrong :/");
            }
        }
        [HttpPost]
        public IActionResult InsertDoctor(InsertDoctorRequest request)
        {
            var res = _service.InsertDoctor(request);
            if (!res.Equals(null))
            {
                return Ok(res);
            }
            else
            {
                return BadRequest("Something went wrong :/");
            }
        }

        [HttpPut]
        public IActionResult ModifyDoctor(ModifyDoctorRequest request)
        {
            var res = _service.ModifyDoctor(request);
            if (!res.Equals(null))
            {
                return Ok(res);
            }
            else
            {
                return BadRequest("Something went wrong :/");
            }
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteDoctor(int id)
        {
            var res = _service.DeleteDoctor(id);
            if (!res.Equals(null))
            {
                return Ok(res);
            }
            else
            {
                return BadRequest("Something went wrong :/");
            }
        }
    }
}