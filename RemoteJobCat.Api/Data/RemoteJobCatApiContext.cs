using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RemoteJobCat.Api.Models;

namespace RemoteJobCat.Api.Data
{
    public class RemoteJobCatApiContext : DbContext
    {
        public RemoteJobCatApiContext (DbContextOptions<RemoteJobCatApiContext> options)
            : base(options)
        {
        }

        public DbSet<RemoteJobCat.Api.Models.Employee> Employee { get; set; }

        public DbSet<RemoteJobCat.Api.Models.Recommendation> Recommendation { get; set; }

        public DbSet<RemoteJobCat.Api.Models.InternalRecommendation> InternalRecommendation { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Rate>()
                .Property(p => p.Amount)
                .HasColumnType("decimal(18,2)");
        }

        public DbSet<RemoteJobCat.Api.Models.Employer> Employer { get; set; }

        public DbSet<RemoteJobCat.Api.Models.Job> Job { get; set; }
    }
}
