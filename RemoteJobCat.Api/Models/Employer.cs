using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RemoteJobCat.Api.Models
{
    public class Employer
    {
        public Guid Id { get; set; }

        public string CompanyName { get; set; }

        public string Description { get; set; }

        public Address Address { get; set; }

        public string ContactPersonNames { get; set; }

        public string ContactPersonEmail { get; set; }

        public int ContactPhone { get; set; }

        public ICollection<Job> Jobs { get; set; }

        public bool IsActive { get; set; }

        public bool IsBlocked { get; set; }

        public ICollection<Report> Reports { get; set; }
    }
}
