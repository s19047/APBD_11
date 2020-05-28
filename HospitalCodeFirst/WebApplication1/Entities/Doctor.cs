using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Entities
{
    public class Doctor
    {
        public int IdDoctor { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        // Every Dcotor will have a list of prescriptions that he/she prescribed ( List might be empty ) 
        public ICollection<Prescription> Prescriptions { get; set; }
    }
}
