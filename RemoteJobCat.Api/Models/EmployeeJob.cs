using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RemoteJobCat.Api.Models
{
    public class EmployeeJob
    {
        public Guid EmployeeId { get; set; }

        public Employee Employee { get; set; }

        public Guid JobId { get; set; }

        public Job Job { get; set; }

        public bool IsApproved { get; set; }

        public bool IsRejected { get; set; }

        public bool IsPendingApproval { get; set; }
    }
}
