using BasicCar;
using ECar;

Car car1 = new Car("Honda","civic",2008);
ElectricCar car2 = new ElectricCar("Tesla","Model X",2022);

car1.Drive(100, 2f);
car2.Drive(100, 2f);

Console.WriteLine(car1.CarAge);
Console.WriteLine(car2.CarAge);

Console.WriteLine(car1.Mileage);
Console.WriteLine(car2.Mileage);
Console.WriteLine(car2.BatteryCharge);

car2.ChargeBattery(100);
Console.WriteLine(car2.BatteryCharge);


