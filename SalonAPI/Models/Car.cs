using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalonAPI.Models
{
    public class Car
    {
        public int id { get; set; }
        public string marka { get; set; }
        public string model { get; set; }
        public string kolor { get; set; }
        public int rocznik { get; set; }
        public int przebieg { get; set; }
        public int moc { get; set; }
        public int drzwi { get; set; }
        public int cena { get; set; }
    }
}
