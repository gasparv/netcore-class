using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ex_13_ControllersAndApi.Models.Api;
using Ex_13_ControllersAndApi.Services.Definitions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ex_13_ControllersAndApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Coffee")]
    public class CoffeeController : Controller
    {
        private readonly IBeverageService _coffeeService;
        public CoffeeController(IBeverageService coffeeService)
        {
            _coffeeService = coffeeService;
        }
        // GET: api/Coffee
        [HttpGet]
        public IActionResult Get()
        {
            //Returns all coffees inside the collection
            return Ok(_coffeeService.All());
        }

        // GET: api/Coffee/5

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            //Returns status code 200 with coffee retrieved from a service - notice the separation of concerns. The controller does not care about the logic behind retrieving the data
            return Ok(_coffeeService.SingleById(id));
            //Presents the possibility to return various status codes with any wanted data
           // return StatusCode(StatusCodes.Status418ImATeapot,new Coffee() { Id=1, Name="OOlong tee - not coffee :(",PlantingOrigin="Slovakia"});
        }

        [HttpGet("[action]")]
        public IActionResult SingleByName([FromQuery]string name)
        {
            //Returns status code 200 with coffee retrieved from a service - notice the separation of concerns. The controller does not care about the logic behind retrieving the data
            return Ok(_coffeeService.SingleByName(name));
            //Presents the possibility to return various status codes with any wanted data
            // return StatusCode(StatusCodes.Status418ImATeapot,new Coffee() { Id=1, Name="OOlong tee - not coffee :(",PlantingOrigin="Slovakia"});
        }

        [HttpGet("[action]")]
        public IActionResult FindByName([FromQuery]string name)
        {
            //Returns status code 200 with coffee retrieved from a service - notice the separation of concerns. The controller does not care about the logic behind retrieving the data
            return Ok(_coffeeService.FindByName(name));
            //Presents the possibility to return various status codes with any wanted data
            // return StatusCode(StatusCodes.Status418ImATeapot,new Coffee() { Id=1, Name="OOlong tee - not coffee :(",PlantingOrigin="Slovakia"});
        }

        // POST: api/Coffee
        [HttpPost]
        
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Coffee/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        [HttpDelete("{id}")]
        /// <summary>
        /// Deletes your selected coffee
        /// </summary>
        public void Delete(int id)
        {
        }
    }
}
