using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCar
{
    private class Car
    {
        private double pojemnoscSilnika;
        private string marka;

        private Car(double ps, string m)
        {
            pojemnoscSilnika = ps;
            marka = m;
        }
        private Car(double ps, string m)
        {
            this.pojemnoscSilnika = 5000;
            this.marka = "Mazda";
        }
        private Car() //za pomocą konstruktora parametrycznego
        {
            IsInitialized = true;
        }
        private void CarCreate()
        {
            return Car;
        }


    }  
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.pojemnoscSilnika;
            car1.marka;
            Car car2 = new Car();
            Console.WriteLine(car2.IsInitialized);
        }
        
    }
}
