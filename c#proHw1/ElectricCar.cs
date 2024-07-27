using BasicCar;

namespace ECar
{
    public class ElectricCar:Car
    {
        private double batteryCharge = 0;
        private double batteryMaxCharge = 2000;

        public double BatteryCharge { get { return batteryCharge; } private set { batteryCharge = value; } }

        public ElectricCar(string brand, string model, int YearOfCreation) : base(brand, model, YearOfCreation)
        {
            BatteryCharge = batteryMaxCharge;
        }
     
        public void ChargeBattery(double Value) 
        {
            BatteryCharge += Value;
            BatteryCharge = Math.Clamp(BatteryCharge, 0, batteryMaxCharge);
        }

        public override float Drive(float Distance, float Time)
        {
            BatteryCharge -= Distance;
            return base.Drive(Distance, Time);
        }
    }
}
