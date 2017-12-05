using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyVehicle
{
    public class Kia : Car, IDrive
    {
        public override string StartEngine()
        {
            return base.StartEngine();
        }

        public override string StopEngine()
        {
            return base.StopEngine();
        }

        public override string Drive(Direction direction)
        {
            return base.Drive(direction);
        }

        public override string Brake()
        {
            return base.Brake();
        }
    }
}
