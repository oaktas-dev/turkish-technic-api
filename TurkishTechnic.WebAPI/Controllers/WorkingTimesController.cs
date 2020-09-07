using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TurkishTechnic.Business.Abstract;
using TurkishTechnic.Business.Constants;
using TurkishTechnic.Entities;

namespace TurkishTechnic.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkingTimesController : ControllerBase
    {
        private IWorkingTimeService _workingTimeService;

        public WorkingTimesController(IWorkingTimeService workingTimeService)
        {
            _workingTimeService = workingTimeService;
        }
        [HttpPost]
        [Authorize]
        public IActionResult Add(WorkingTime workingTime)
        {
            var result = _workingTimeService.Add(workingTime);

            if (result.Success)
                return Ok(result.Message);

            return BadRequest(result.Message);
        }
    }
}
