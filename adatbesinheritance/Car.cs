using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adatbesinheritance
{
    public class Car
    {
        public static List<Car> cars=new List<Car>();

        public int id { get; set; }
        public string make { get; set; }
        public string model { get; set; }
        public string color { get; set; }
        public int year { get; set; }
        public int hp { get; set; }
        
    }
}
