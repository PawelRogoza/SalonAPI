using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SalonAPI.Models;
using SalonAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalonAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarRepository carRepository;

        public CarController(ICarRepository carRepository)
        {
            this.carRepository = carRepository;
        }


        // GET all cars
        [HttpGet]
        public IEnumerable<Car> GetCars()
        {
            return carRepository.GetAll();
        }

        // GET car by ID
        [HttpGet("{id}")]
        public ActionResult<Car> GetCar(int id)
        {
            var Car = carRepository.GetById(id);

            if (Car == null)
            {
                return NotFound();
            }

            return Ok(Car);
        }

        // POST car
        [HttpPost]
        public ActionResult<Car> PostCar(Car car)
        {
            carRepository.Add(car);
            carRepository.Save();

            return CreatedAtAction(nameof(GetCar), new { id = car.id }, car);
        }

        // PUT car
        [HttpPut("{id}")]
        public ActionResult<Car> PutCar(int id, Car car)
        {
            if (id != car.id)
            {
                return BadRequest();
            }

            carRepository.Update(car);
            carRepository.Save();

            return NoContent();
        }

        // DELETE car
        [HttpDelete("{id}")]
        public ActionResult<Car> DeleteCar(int id)
        {
            carRepository.Delete(id);
            carRepository.Save();

            return NoContent();
        }

    }
}

