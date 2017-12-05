using System;

namespace MyVehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            Car kia = new Kia();

           Console.WriteLine(kia.StartEngine());
           Console.WriteLine(kia.Drive(Vehicle.Direction.Forward));
           Console.WriteLine(kia.Brake());
           Console.WriteLine(kia.StopEngine());
        }
    }
}
