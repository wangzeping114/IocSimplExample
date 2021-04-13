using Microsoft.AspNetCore.Mvc;
using System;
using webApiDemo.Domain.Entities.DTOs;
using webApiDemo.Domain.Interfaces;

namespace webApiDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClubController : ControllerBase
    {
        private readonly IServiceClub _serviceClub;

        public ClubController(IServiceClub serviceClub)=>
             _serviceClub = serviceClub;

        [HttpGet]
        [Route("CalculatePercentage")]
        public IActionResult CalculatePercentage([FromQuery] ClubDTO clubDTO)
        {
            try
            {
                var data = _serviceClub.CalculatePercentage(clubDTO);

                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
