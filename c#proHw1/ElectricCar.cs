using BasicCar;

namespace ECar
{
    public class ElectricCar:Car
    {
        private double batteryCharge = 0;
        private double batteryMaxCharge = 2000;

        public ElectricCar(string brand, string model, int YearOfCreation) : base(brand, model, YearOfCreation)
        {
            this.batteryCharge = batteryMaxCharge;
        }

        public double BatteryCharge => batteryCharge;

        public void ChargeBattery(double Value)
        {
            batteryCharge += Value;
            batteryCharge = Math.Clamp(batteryCharge, 0, batteryMaxCharge);
        }

        public override float Drive(float Distance, float Time)
        {
            batteryCharge -= Distance;
            return base.Drive(Distance, Time);
        }
    }
}
