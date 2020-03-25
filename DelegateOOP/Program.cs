using System;
using System.Collections;

namespace DelegateOOP
{
    class Car 
    {
        int _temperature;
        string _name;
        int _tachoMeter;
        int _max;
        public int TachoMeter 
        { 
            get { return _tachoMeter; } 
            set { _tachoMeter = value; } 
        }
        public Car(string Name)
        {
            this._name = Name;
        }
        public void UpTacho()
        {

        }

        public void DownTacho()
        {

        }


    }




    delegate string Mydelegate(string s);
    

    class Program
    {
       
        static void Main(string[] args)
        {
            
           
        }
    }
}
