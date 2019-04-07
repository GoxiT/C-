using Library.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars_GasStation
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("Opel", "Astra", "Granit", 50, true, false);



            Console.WriteLine(Car.GetCarStats(myCar));
            Console.WriteLine("----------");


            if (myCar.HaveKeys == true)
            {
                Console.WriteLine("Alright bro , you got the keys !!");
                Console.WriteLine("Now enter how much fuel do you have in liters: ");
                int fuel = int.Parse(Console.ReadLine());
                if (fuel > 5)
                {
                    if(myCar.IsDrivable == false)
                    {
                        Console.WriteLine("Oh but you have a flat tire");
                        GasStation.PumpUpTires(myCar);
                        Console.WriteLine("---------------------------");

                    }

                    myCar.StartCar();
                    myCar.StartLights();
                    myCar.Drive("OhriT");
                    Console.WriteLine("Dont drink and drive Ok !!");
                }
                else
                {
                    Console.WriteLine("You dont have enough fuel !!");
                }
            }
            else
            {
                Console.WriteLine("How do you want to start the car Without keys ?!");
            }


            Console.ReadLine();
        }
    }
}
