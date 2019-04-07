using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Classes
{
    public partial class Car
    {
        public void StartCar()
        {
            Console.WriteLine("You started the Car : Brm brm brm brm");
        }
        public void StartLights()
        {
            Console.WriteLine("You turned on the lights : Flash Flash");
        }
        public static string GetCarStats(Car car)
        {
            return $"Car description :{car.Brand}, {car.Model}, {car.Color} Color";
        }
    }
}
