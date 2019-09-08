using EquinityExercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EquinityExercise.DTOs
{
    public class InterviewDTO
    {
        public int Id { get; set; }
        public bool IsInterviewResultPositive { get; set; }
        public JobCandidate JobCandidate { get; set; }

        public InterviewDTO(Interview interview)
        {
            Id = interview.Id;
            IsInterviewResultPositive = interview.IsInterviewResultPositive;
            JobCandidate = interview.JobCandidate;
        }
    }
}
