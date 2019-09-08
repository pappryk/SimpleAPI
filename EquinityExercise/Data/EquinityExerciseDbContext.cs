using EquinityExercise.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EquinityExercise.Data
{
    public class EquinityExerciseDbContext : DbContext
    {
        public DbSet<Interview> Interviews { get; set; }
        public DbSet<JobCandidate> JobCandidates { get; set; }

        public EquinityExerciseDbContext(DbContextOptions options) : base(options)
        {
            // Just add some sample data

            if (Interviews.ToList().Count != 0)
                return;
            
            var candidate1 = new JobCandidate() { Name = "Patryk Nguyen" };
            var candidate2 = new JobCandidate() { Name = "Somebody else" };

            JobCandidates.Add(candidate1);
            JobCandidates.Add(candidate2);

            Interviews.Add(new Interview() {JobCandidateId = 1, IsInterviewResultPositive = true });
            Interviews.Add(new Interview() {JobCandidateId = 2, IsInterviewResultPositive = false });

            this.SaveChanges();
        }


    }
}
