using AutomobileInventory.Core;
using AutomobileInventory.Core.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace AutomobileInventory.Web.Controllers
{
    [Route("api/[controller]")]
    public class CarsController : Controller
    {
        private CarsRepository repo = new CarsRepository(null);
        // GET api/values
        [HttpGet]
        public IEnumerable<Car> Get()
        {
            return repo.GetCars();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Car Get(int id)
        {
            return repo.GetCar(id);
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]Car value)
        {
            try
            {
                repo.AddCar(value);
                return Ok(value);
            }

            catch (Exception e)
            { return StatusCode(500, e); }
        }

        // PUT api/values/5
        [HttpPut]
        public IActionResult Put([FromBody]Car value)
        {
            try
            {
                repo.UpdateCar(value);
                return Ok(value);
            }

            catch (Exception e)
            { return StatusCode(500, e); }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                repo.DeleteCar(id);
                return Ok();
            }

            catch (Exception e)
            { return StatusCode(500, e); }
        }
    }
}
