using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Speed { get; set; }
        public string CarCode { get; set; }
        public Car()
        {

        }
        public Car(int id, string name, int speed, string carCode)
        {
            Id = id;
            Name = name;
            Speed = speed;
            CarCode = carCode;
        }
    }
}
