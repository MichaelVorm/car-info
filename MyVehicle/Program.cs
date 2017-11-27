using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyVehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

           Console.WriteLine(car.StartEngine());
           Console.WriteLine(car.Drive(Vehicle.Direction.Forward));
           Console.WriteLine(car.Brake());
           Console.WriteLine(car.StopEngine());
        }
    }
}
