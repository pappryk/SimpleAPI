using EquinityExercise.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EquinityExercise.Data
{
    public class InterviewCRUDProvider
    {
        private EquinityExerciseDbContext _Context { get; set; }

        public InterviewCRUDProvider(EquinityExerciseDbContext context)
        {
            _Context = context;
        }

        public Interviews GetAll()
        {
            var interviewsData = _Context.Interviews
                                            .Include(i => i.JobCandidate)
                                            .ToList();
            var interviews = new Interviews(interviewsData);

            return interviews;
        }

        public Interviews GetPositiveInterviews()
        {
            var interviewsData = _Context.Interviews
                                            .Include(i => i.JobCandidate)
                                            .ToList();
            var interviews = new Interviews(interviewsData);

            return interviews.GetPositiveInterviews();
        }

        public void AddInterview(Interview interview)
        {
            _Context.Interviews.Add(interview);
            _Context.SaveChanges();
        }
    }
}
