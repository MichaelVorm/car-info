namespace MyVehicle
{
    public class Car : Vehicle
    {
        public Car()
        {

        }

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
