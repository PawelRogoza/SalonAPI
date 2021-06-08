using SalonAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalonAPI.Repository
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetAll();
        Car GetById(int id);
        void Add(Car car);
        void Update(Car car);
        void Delete(int id);
        void Save();
    }
}
