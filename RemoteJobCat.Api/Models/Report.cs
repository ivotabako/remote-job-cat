
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

        public Guid EmployerId { get; set; }

        public Guid EmployeeId { get; set; }
    }
}
