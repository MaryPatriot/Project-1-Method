using System;
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


            string vehicle;
            Console.WriteLine("Type of vehicle?");
            Console.WriteLine("1:Car");
            Console.WriteLine("2: Truck");
            Console.WriteLine("3: Bus");
            vehicle = Console.ReadLine();

            Carcharge(vehicle);




            Console.WriteLine("Hour vehicle enetered lot: (0-24)");
            int Hourenter = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Minute vehicle enetered lot: (0-60)");
            int Minenter = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hour vehicle left lot: (0-24)");
            int Hourleft = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Minute vehicle left lot: left lot: (0-60)");
            int Minleft = Convert.ToInt32(Console.ReadLine());


            Spenttime(Hourenter, Minenter, Hourleft, Minleft);
         


        }

// Method to calculate actual time spent in parking by vehicle. 
        static void Spenttime(int Hourenter, int Minenter, int Hourleft, int Minleft)
        {

            if (Minleft < Minenter)
            {
                Minleft = Minleft + 60;
                Hourleft = Hourleft - 1;
                int hourspent = Hourleft - Hourenter;
                int Minspent = Minleft - Minenter;
                Console.WriteLine(hourspent );
                Console.WriteLine(Minspent);
            }
            else
            {
                int hourspent = Hourleft - Hourenter;
                int Minspent = Minleft - Minenter;
                Console.WriteLine(hourspent);
                Console.WriteLine(Minspent);
            }


            // Mehod to calculate parking charge for car.

            static void Carcharge(string vehicle)
            {
                if (vehicle == 1:Car)
                {
                while (true)
                {

                }

                }    

            }











        }
    }
}
