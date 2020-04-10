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

        public ICollection<EmployeeJob> EmployeeJob { get; set; }

        public bool IsActive { get; set; }

        public bool IsBlocked { get; set; }

        public string ShortSelfIntroduction { get; set; }

        public string Title { get; set; }

        public string Experience { get; set; }

        public Rate Rate { get; set; }

        public ICollection<Recommendation> Recommendations { get; set; }

        public Uri LinkedInProfileUrl { get; set; }

        public ICollection<InternalRecommendation> InternalRecommendations { get; set; }
    }
}
