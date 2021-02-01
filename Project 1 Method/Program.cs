﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1_Method
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("*********************************************************************************************************");
            Console.WriteLine("Maryam Vatanparast");
            Console.WriteLine("C# 1th project");
            Console.WriteLine("**********************************************************************************************************");
           
               //Try to do data validation but gives error!
               
                Console.WriteLine("Type of vehicle? ");
                Console.WriteLine("Car");
                Console.WriteLine("Bus");
                Console.WriteLine("Truck");
                string Vehicle= Console.ReadLine();

            Console.WriteLine("Hour vehicle enetered lot: (0-24)");
            int Hourenter = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Minute vehicle enetered lot: (0-60)");
            int Minenter = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hour vehicle left lot: (0-24)");
            int Hourleft = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Minute vehicle left lot: left lot: (0-60)");
            int Minleft = Convert.ToInt32(Console.ReadLine());
            int hourspent = Hourleft - Hourenter;
            int minspent = Minleft - Minenter;
            double Totalspenttime = Spenttime(Hourenter, Minenter, Hourleft, Minleft, hourspent, minspent);
            Console.WriteLine($"Totalspentime: {Totalspenttime}");

            double vehicleCharge = VehicleCharge(Vehicle, Totalspenttime);
            Console.WriteLine($"vehicleCharge: {vehicleCharge}");
            Outputformat(Vehicle, Hourenter, Minenter, Hourleft, Minleft, hourspent, minspent, Totalspenttime, vehicleCharge);


        }

        // Method to calculate actual time spent in parking by vehicle. 
        static double Spenttime(int Hourenter, int Minenter, int Hourleft, int Minleft, int hourspent, int minspent)
        {

            if (Minleft < Minenter)
            {
                Minleft = Minleft + 60;
                Hourleft = Hourleft - 1;

                hourspent = Hourleft - Hourenter;

                minspent = Minleft - Minenter;

                double Totalspenttime = hourspent + Math.Ceiling((minspent / 15) * 0.25);
                Console.WriteLine(hourspent);
                Console.WriteLine(minspent);
                Console.WriteLine(Totalspenttime);
                return Totalspenttime;

            }
            else
            {

                hourspent = Hourleft - Hourenter;

                minspent = Minleft - Minenter;


                double Totalspenttime = hourspent + Math.Ceiling((minspent / 15) * 0.25);
                Console.WriteLine(Totalspenttime);
                Console.WriteLine(hourspent);
                Console.WriteLine(minspent);
                return Totalspenttime;
            }
        }

        // Mehod to calculate parking charge!

        static double VehicleCharge(string vehicle, double Totalspenttime)
        {




            if (vehicle == "Car" && Totalspenttime <= 3)
            {
                double VehicleCharge = 0;
                Console.WriteLine(VehicleCharge);
                return VehicleCharge;

            }
            else if (vehicle == "Car" && Totalspenttime > 3)
            {
                double Newtime = Totalspenttime - 3;
                double VehicleCharge = Newtime * 1.50;
                Console.WriteLine(VehicleCharge);
                return VehicleCharge;
            }

            else if (vehicle == "Bus" && Totalspenttime <= 1)
            {
                double VehicleCharge = Totalspenttime * 2.00;
                Console.WriteLine(VehicleCharge);
                return VehicleCharge;
            }
            else if (vehicle == "Bus" && Totalspenttime > 1)
            {
                double Newtime = Totalspenttime - 1;
                double VehicleCharge = Newtime * 3.70 + Totalspenttime * 2.00;
                Console.WriteLine(VehicleCharge);
                return VehicleCharge;
            }
            else if (vehicle == "Truck" && Totalspenttime <= 2)
            {
                double VehicleCharge = Totalspenttime * 1.00;
                Console.WriteLine(VehicleCharge);
                return VehicleCharge;

            }
            else if (vehicle == "Truck" && Totalspenttime > 2)
            {
                double Newtime = Totalspenttime - 2;
                double VehicleCharge = Newtime * 2.50 + Totalspenttime * 1.00;
                Console.WriteLine(VehicleCharge);
                return VehicleCharge;
            }
            else
            {
                Console.WriteLine("Error");
                return 0;
            }


        }
        //Method for output format!
        static void Outputformat(string Vehicle, int Hourenter, int Minenter, int Hourleft, int Minleft, int hourspent, int minspent, double Totalspenttime, double vehicleCharge)
        {
            Console.WriteLine($"TYPE OF VEHICLE: {Vehicle}");
            Console.WriteLine($"TIME-IN: {Hourenter} : {Minenter}");
            Console.WriteLine($"TIME-OUT: {Hourleft} : {Minleft}");
            Console.WriteLine($"PARKING-TIME: {hourspent}: {minspent}");//Correct here!
            Console.WriteLine($"ROUNDED TOTAL: {Totalspenttime}");
            Console.WriteLine($"TOTAL CHARGES: {vehicleCharge}");


        }
















    }
}























