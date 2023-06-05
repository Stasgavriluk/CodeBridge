using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeBridgeApi.Dtos;
using CodeBridgeApi.Models;
using CodeBridgeApi.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CodeBridgeApi.Controllers
{
    [Route("")]
    [ApiController]
    public class DogsController : Controller
    {
        private readonly IDogsService _dogsService;

        public DogsController(IDogsService dogsService)
        {
            _dogsService = dogsService;
        }
        [HttpGet("ping")]
        public string Ping()
        {
            return "Dogs house service. Version 1.0.1";
        }
        
        // GET: api/values
        [HttpGet("dogs")]
        public async Task<ActionResult<List<DogsDto>>> Dogs()
        {
            return Ok(await _dogsService.Dogs());
        }

        // POST api/values
        [HttpPost("dog")]
        public async Task<ActionResult<List<DogsDto>>> AddDog(AddDogsDto dogsModel)
        {
            var result = await _dogsService.AddDog(dogsModel);            
            return Ok(result);
        }
    }
}

