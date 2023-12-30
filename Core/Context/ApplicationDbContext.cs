using backend.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace backend.Core.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Company> companies { get; set; }
        public DbSet<Job> jobs { get; set; }
        public DbSet<Candidate> candidates { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Relation of Jobs Table
            modelBuilder.Entity<Job>()
                // one job exist in one company
                .HasOne(job => job.company)
                // company has many jobs
                .WithMany(company => company.jobs)
                // table jobs has foreign key from tabel companies named company id
                .HasForeignKey(jobs => jobs.companyId);

            modelBuilder.Entity<Candidate>()
                // Candidate can be have one jobe only 
                .HasOne(candidate => candidate.job)
                // job can be have many candidate
                .WithMany(jobs => jobs.candidates)
                .HasForeignKey(candidate => candidate.jobId);
  
        }
    }
}
