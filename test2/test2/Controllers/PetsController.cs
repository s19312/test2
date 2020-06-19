using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test2.Services;

namespace test2.Controllers
{
    [ApiController]
    [Route("api/volunteers")]

    public class PetsController : ControllerBase
    {
        private readonly PetsController _service;
        public PetsController(PetsController service)
        {
            _service = service;
        }

        [HttpGet("api/volunteers/{id}/pets")]
        public IActionResult GetPets(int id,string year)
        {
            try { 

            }
            return Ok(_service.GetPets(id, year));
        }
    }
}
