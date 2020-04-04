﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RemoteJobCat.Api.Models
{
    public class Job
    {
        public Guid Id { get; set; }

        public string Description { get; set; }

        public string Location { get; set; }

        public TimeSpan? Duration { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public bool IsPermanent { get; set; }

        public Money FixedSalaryPerHour { get; set; }

        public Range<Money> MoneyRange { get; set; }

        public Guid EmployerId { get; set; }

        public List<Employee> ApprovedApplicants = new List<Employee>();

        public List<Employee> PendingApplicants = new List<Employee>();

        public List<Employee> RejectedApplicants = new List<Employee>();
    }
}