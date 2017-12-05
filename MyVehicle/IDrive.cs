using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyVehicle.Vehicle;

namespace MyVehicle
{
    public interface IDrive
    {
        string StartEngine();
        string StopEngine();
        string Drive(Direction direction);
        string Brake();
    }
}
