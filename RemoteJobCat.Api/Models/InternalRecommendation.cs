using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RemoteJobCat.Api.Models
{
    public class InternalRecommendation
    {
        public Guid Id { get; set; }

        public Guid RecommendedEmployee { get; set; }

        public string Description { get; set; }

        public Guid RecommendatorEmployee { get; set; }
    }
}
