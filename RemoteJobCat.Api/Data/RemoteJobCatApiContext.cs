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

        public DbSet<RemoteJobCat.Api.Models.Employer> Employer { get; set; }

        public DbSet<RemoteJobCat.Api.Models.Job> Job { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Rate>()
                .Property(p => p.Amount)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Employer>()
                        .HasMany(c => c.Jobs)
                        .WithOne(j => j.Employer);

            modelBuilder.Entity<Employer>()
                        .HasMany(c => c.Reports)
                        .WithOne(e => e.Employer);

            modelBuilder.Entity<Employee>()
                        .HasMany(c => c.Recommendations)
                        .WithOne(e => e.Employee);

            modelBuilder.Entity<Employee>()
                        .HasMany(c => c.InternalRecommendations)
                        .WithOne(e => e.RecommendedEmployee);

            modelBuilder.Entity<EmployeeJob>()
                .HasKey(bc => new { bc.JobId, bc.EmployeeId });
            modelBuilder.Entity<EmployeeJob>()
                .HasOne(bc => bc.Employee)
                .WithMany(b => b.EmployeeJob)
                .HasForeignKey(bc => bc.EmployeeId);
            modelBuilder.Entity<EmployeeJob>()
                .HasOne(bc => bc.Job)
                .WithMany(c => c.EmployeeJob)
                .HasForeignKey(bc => bc.JobId);
        }
    }
}
