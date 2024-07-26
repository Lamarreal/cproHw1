
namespace BasicCar
{
    public class Car
    {
        internal string Brand = string.Empty;
        internal string Model = string.Empty;
        internal int age = 0;
        internal int yearOfCreation = 0;

        private double mileage = 0;
        public virtual double Mileage => mileage;
        public int CarAge => age;
        public int CarCreationYear => yearOfCreation;
        public virtual float Drive(float Distance, float Time)
        {
            mileage += Distance;
            return Distance / Time;
        }

        public Car()
        {
            Brand = string.Empty;
            Model = string.Empty;
            this.mileage = 0;
            yearOfCreation = DateTime.Now.Year;
            age = yearOfCreation - DateTime.Now.Year;
        }

        public Car(string brand, string model)
        {
            Brand = brand;
            Model = model;
            this.mileage = 0;
            yearOfCreation = DateTime.Now.Year;
            age = DateTime.Now.Year - yearOfCreation;
        }

        public Car(string brand, string model, int YearOfCreation)
        {
            Brand = brand;
            Model = model;
            this.mileage = 0;
            this.yearOfCreation = YearOfCreation;
            age = DateTime.Now.Year - this.yearOfCreation;
        }
        ~Car()
        {
            Console.WriteLine("car Destroyed");
        }
    }


}
