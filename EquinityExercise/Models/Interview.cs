using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EquinityExercise.Models
{
    public class Interview
    {
        [Key]
        public int Id { get; set; }
        public bool IsInterviewResultPositive { get; set; }
        public int JobCandidateId { get; set; }
        public JobCandidate JobCandidate { get; set; }
    }
}
