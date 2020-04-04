using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RemoteJobCat.Api.Models
{
    public class Employee
    {
        public Guid Id { get; set; }

        public int Age { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Phone { get; set; }

        public string Email { get; set; }

        public int CoutryCode { get; set; }
    }
}
