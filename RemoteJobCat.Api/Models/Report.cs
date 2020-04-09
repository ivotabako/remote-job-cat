
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RemoteJobCat.Api.Models
{
    public class Report
    {
        public Guid Id { get; set; }

        public string Desctiption { get; set; }

        public Employer Employer { get; set; }

        public Employee Employee { get; set; }
    }
}
