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
        public DbSet<HiringManager> HiringManager { get; set; }
        public DbSet<Interview> Interviews { get; set; }
        public DbSet<JobCandidate> JobCandidates { get; set; }

        public EquinityExerciseDbContext()
        {

        }


    }
}
