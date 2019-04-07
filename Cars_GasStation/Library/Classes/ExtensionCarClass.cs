using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Classes
{
    public static class ExtensionCarClass
    {
        public static void Drive(this Car car , string place)
        {
            Console.WriteLine($"Driving my {car.Brand} {car.Model} to {place}");
        }
    }
}
