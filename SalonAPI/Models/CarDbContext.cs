using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalonAPI.Models
{
    public class CarDbContext : DbContext
    {
            public CarDbContext()
            {
            }

            public CarDbContext(DbContextOptions<CarDbContext> options) : base(options)
            {

            }
            public DbSet<Car> Car { get; set; }
    }
}
