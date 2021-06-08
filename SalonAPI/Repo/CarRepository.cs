using Microsoft.EntityFrameworkCore;
using SalonAPI.Models;
using SalonAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalonAPI.Repo
{
    public class CarRepository : ICarRepository
    {
        private readonly CarDbContext _dbcontext;

        public CarRepository(CarDbContext context)
        {
            this._dbcontext = context;
        }
        public void Add(Car car)
        {
            _dbcontext.Car.Add(car);
        }

        public void Delete(int id)
        {
            var Note = _dbcontext.Car.Find(id);
            if (Note == null) return;

            _dbcontext.Car.Remove(Note);
        }

        public IEnumerable<Car> GetAll()
        {
            return _dbcontext.Car.ToList();
        }

        public Car GetById(int id)
        {
            var Car = _dbcontext.Car.Find(id);
            return Car;
        }

        public void Save()
        {
            _dbcontext.SaveChanges();
        }

        public void Update(Car car)
        {
            _dbcontext.Entry(car).State = EntityState.Modified;
        }
    }
}
