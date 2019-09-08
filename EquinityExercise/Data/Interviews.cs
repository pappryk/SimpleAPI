using EquinityExercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EquinityExercise.Data
{
    public class Interviews
    {
        private IEnumerable<Interview> _ContainedData { get; set; }
        public IEnumerable<Interview> ContainedData { get => _ContainedData; }

        public Interviews(IEnumerable<Interview> containedData)
        {
            _ContainedData = containedData;
        }

        public Interviews GetPositiveInterviews()
        {
            var newContainedData = _ContainedData.Where(interview => interview.IsInterviewResultPositive);

            return new Interviews(newContainedData);
        }
    }
}
