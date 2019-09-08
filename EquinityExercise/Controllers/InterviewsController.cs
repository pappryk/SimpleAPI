using EquinityExercise.Data;
using EquinityExercise.DTOs;
using EquinityExercise.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EquinityExercise.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InterviewsController : ControllerBase
    {
        private InterviewCRUDProvider crudProvider { get; set; }

        public InterviewsController(EquinityExerciseDbContext context)
        {
            crudProvider = new InterviewCRUDProvider(context);
        }

        [HttpGet("all")]
        public IEnumerable<InterviewDTO> GetAll()
        {
            return crudProvider.GetAll()
                               .ContainedData
                               .Select(i => new InterviewDTO(i));
        }

        [HttpGet("positive")]
        public IEnumerable<InterviewDTO> GetPositive()
        {
            return crudProvider.GetPositiveInterviews()
                               .ContainedData
                               .Select(i => new InterviewDTO(i));
        }

        [HttpPost]
        public void Post([FromBody] Interview interview)
        {
            crudProvider.AddInterview(interview);
        }
    }
}
