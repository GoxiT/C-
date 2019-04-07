using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Classes
{
    public static class GasStation
    {
        public static void Refill(Car car)
        {
            Console.WriteLine("You Refilled the Car with 10 Liters");
        }
        public static void PumpUpTires(Car car)
        {
            if(car.IsDrivable == false)
            {
                car.IsDrivable = true;
                Console.WriteLine($"You pumped up the tires on the {car.Brand} , your car is drivable now");
            }
        }
    }
}
