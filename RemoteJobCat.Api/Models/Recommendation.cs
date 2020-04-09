using System;

namespace RemoteJobCat.Api.Models
{
    public class Recommendation
    {
        public Guid Id { get; set; }

        public string Content { get; set; }

        public Employee Employee { get; set; }
    }
}