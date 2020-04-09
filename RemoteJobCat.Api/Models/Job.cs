using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RemoteJobCat.Api.Models
{
    public class Job
    {
        public Guid Id { get; set; }

        public string Description { get; set; }

        public string Location { get; set; }

        public bool IsFinished { get; set; }

        public bool IsRecruitmentInProgress { get; set; }

        public TimeSpan? Duration { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public bool IsPermanent { get; set; }

        public Rate FixedRate { get; set; }

        [NotMapped]
        public Range<Rate> RateRange { get; set; }

        public Employer Employer { get; set; }

        public ICollection<EmployeeJob> EmployeeJob { get; set; }
    }
}
