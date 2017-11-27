using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyVehicle
{
    public abstract class Vehicle
    {

        public enum Direction
        {
            Forward = 0,
            Backward = 1,
            Left = 2,
            Right = 3
        }

        public virtual string StartEngine()
        {
            return "Engine started";
        }

        public virtual string StopEngine()
        {
            return "Engine stopped";
        }

        public virtual string Drive(Direction direction)
        {
            string result = "";
            switch (direction)
            {
                case Direction.Forward:
                    result = "Drive forward";
                    break;
                case Direction.Backward:
                    result = "Drive backward";
                    break;
                case Direction.Left:
                    result = "Drive left";
                    break;
                case Direction.Right:
                    result = "Drive right";
                    break;
            }

            return result;
        }

        public virtual string Brake()
        {
            return "Brake!";
        }
    }
}
