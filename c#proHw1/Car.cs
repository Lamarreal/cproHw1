
namespace BasicCar
{
    public class Car
    {
        private string brand = string.Empty;
        private string model = string.Empty;     
        private int yearOfCreation = 0;

        private double mileage = 0;
        public virtual double Mileage { get { return mileage; } private set { mileage = value; } }
        public int CarAge { get { return DateTime.Now.Year - yearOfCreation; }}
        public int CarCreationYear => yearOfCreation;
        public virtual float Drive(float Distance, float Time)
        {
            Mileage += Distance;
            return Distance / Time;
        }

        public Car()
        {
            brand = string.Empty;
            model = string.Empty;
            Mileage = 0;
            yearOfCreation = DateTime.Now.Year;
        }

        public Car(string _brand, string _model)
        {
            brand = _brand;
            model = _model;
            Mileage = 0;
            yearOfCreation = DateTime.Now.Year;           
        }

        public Car(string _brand, string _model, int YearOfCreation)
        {
            brand = _brand;
            model = _model;
            Mileage = 0;
            this.yearOfCreation = YearOfCreation;
          
        }
        ~Car()
        {
            Console.WriteLine("car Destroyed");
        }
    }


}
