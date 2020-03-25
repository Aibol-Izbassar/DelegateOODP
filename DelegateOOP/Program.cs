using System;
using System.Collections;

namespace DelegateOOP
{
    public delegate void CarTempStatus(int n, string s);
    class Car 
    {
        public CarTempStatus TempStatus;
        int _temperature = 45;
        string _name;
        int _tachoMeter;
        
        public int TachoMeter 
        {
            set { _tachoMeter = value; } 
        }

        public Car(string Name)
        {
            this._name = Name;
        }
        public void TachoTemp()
        {
            if (_temperature >= 45 && _temperature < 90)
            {
                if (_tachoMeter < 2000) 
                {
                    _temperature -= 1;
                }
                if (_tachoMeter > 2000 && _tachoMeter < 4000)
                {
                    _temperature += 5;
                }
                if (_tachoMeter > 4000 && _tachoMeter < 7000)
                {
                    _temperature += 10;
                }
                Console.WriteLine($"{_name} Temperature: {_temperature}");
            }

            else
            {
                TempStatus(_temperature, _name);
            }   
            
        }

    }
    

    class Program
    {
       
        static void Main(string[] args)
        {
            Car car = new Car("Toyota");
            Car car2 = new Car("Audi");
            Random r = new Random();
            car.TachoMeter = r.Next(1000, 7000);
            car2.TachoMeter = r.Next(2000, 7000);
            car.TempStatus = PrintTempStatus;
            car2.TempStatus = PrintTempStatus;

            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine($"*******Это итерация {i} *******");
                car.TachoTemp();
                car2.TachoTemp();
               
            }
        }

        static void PrintTempStatus(int temperature, string name)
        {
            Console.WriteLine($"{name} temperature is critical: {temperature}");
        }
    }
}
