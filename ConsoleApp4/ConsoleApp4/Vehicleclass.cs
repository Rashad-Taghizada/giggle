using System;
using System.Collections.Generic;
using System.Text;
//Vehicle class-
//Color -

//Year

//ps: Buraxilis ili teyin olunmamis Vehicle ola bilmez

//Model-

//FuelCapacity-

//FuelFor1Km-

//CurrentFuel-

//ShowInfo()-butun detallari gosterecek

namespace ConsoleApp4
{
    internal class Vehicleclass
    {
        public string color;
        ////public int year;
        ////public string model;
        ////public int fuelCapacity;
        ////public int fuelFor1Km;
        ////public int currentFuel;
        public Vehicleclass()
        {
             color = "red";
            //year = 2020;
            //model = "BMW";
            //fuelCapacity = 40;
            //fuelFor1Km = 10;
            //currentFuel = 20;
        }
        static void Main(string[] args)
        {
            Vehicleclass Red= new Vehicleclass();
            Console.WriteLine(Red.color);
        }
        //public void ShowInfo()
        //{
            
        //}
        //ShowInfo()-butun detallari gosterecek
        //public class Vehicle(string color, int year, int fuelcapasity, int fuelFor1km, int currentFuel)
        //{

        //}
    }
}
