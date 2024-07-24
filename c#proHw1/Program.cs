
Car car1 = new Car("Honda","civic",2008);
ElectricCar car2 = new ElectricCar("Tesla","Model X",2022);

car1.Drive(100, 2f);
car2.Drive(100, 2f);

Console.WriteLine(car1.Age);
Console.WriteLine(car2.Age);

Console.WriteLine(car1.Mileage);
Console.WriteLine(car2.Mileage);
Console.WriteLine(car2.BatteryCharge);

car2.ChargeBattery(100);
Console.WriteLine(car2.BatteryCharge);


public class Car
{
    public string Brand = string.Empty;
    public string Model = string.Empty;
    internal int Age = 0;
    internal int YearOfCreation = 0;

    private double mileage = 0;
    public virtual double Mileage { get { return mileage; } }
    public int carAge { get { return Age; } }
    public int carCreationYear { get { return YearOfCreation; } }
    public virtual float Drive(float Distance,float Time)
    {
        mileage += Distance;
        return Distance / Time;
    }

    public Car() 
    {
        Brand = string.Empty;
        Model = string.Empty;
        this.mileage = 0;
        YearOfCreation = DateTime.Now.Year;
        Age = YearOfCreation - DateTime.Now.Year;
    }

    public Car(string brand, string model)
    {
        Brand = brand;
        Model = model;
        this.mileage = 0;
        YearOfCreation = DateTime.Now.Year;
        Age = DateTime.Now.Year - YearOfCreation;
    }

    public Car(string brand, string model ,int YearOfCreation)
    {
        Brand = brand;
        Model = model;
        this.mileage = 0;
        this.YearOfCreation = YearOfCreation;
        Age = DateTime.Now.Year - this.YearOfCreation;
    }
    ~Car() 
    {
        Console.WriteLine("car Destroyed");
    }
}

public class ElectricCar:Car
{
    private double mileage = 0;
    private double Charge = 0;
    private double MaxBatteryCapacity = 300;
    public override double Mileage { get { return mileage; } }
    public double BatteryCharge { get { return Charge; } }
    public override float Drive(float Distance, float Time)
    {
        if (Charge - Distance > 0)
        {
            Charge -= Distance;
            mileage += Distance;
            return Distance / Time;
        }
        else
            return 0;
    }

    public void ChargeBattery(double ammount)
    {
        Charge += ammount;
        Charge = Math.Clamp(Charge, 0, MaxBatteryCapacity);
    }
    public ElectricCar()
    {
        Brand = string.Empty;
        Model = string.Empty;
        this.mileage = 0;
        YearOfCreation = DateTime.Now.Year;
        Age = DateTime.Now.Year - YearOfCreation;
        Charge = MaxBatteryCapacity;
    }
    public ElectricCar(string brand, string model) 
    {
        Brand = brand;
        Model = model;
        this.mileage = 0;
        YearOfCreation = DateTime.Now.Year;
        Age = DateTime.Now.Year - YearOfCreation;
        Charge = MaxBatteryCapacity;
    }
    public ElectricCar(string brand, string model, int YearOfCreation)
    {
        Brand = brand;
        Model = model;
        this.mileage = 0;
        this.YearOfCreation = YearOfCreation;
        Age = DateTime.Now.Year - this.YearOfCreation;
        Charge = MaxBatteryCapacity;
    }

    ~ElectricCar()
    {
        Console.WriteLine("Electric car Destroyed");
    }
}
