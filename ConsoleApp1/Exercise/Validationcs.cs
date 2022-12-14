using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Exercise
{
    public class Validationcs
    { 
        public void Hello()

        {
            int item = Convert.ToInt32(Console.ReadLine());
            if (1 <= item && item <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("InValid");
            }

        }
        public void Car()
        {
            Console.WriteLine("enter speed limit of car");
            int SpLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter speed of car");
            int SpCar = Convert.ToInt32(Console.ReadLine());
            if (SpLimit >= SpCar)
            {
                Console.WriteLine("Ok");
            }
            if (SpLimit < SpCar)
            {
                int DemPt = (SpCar - SpLimit) / 5;
                if (DemPt < 12)
                {
                    Console.WriteLine(DemPt);
                }
                else { Console.WriteLine("Licence Suspended" + " " + Convert.ToString(DemPt)); }

            }
        }
        public void fact() {
            Console.WriteLine("enter number");
            var num = Convert.ToInt32(Console.ReadLine());
            var tt = 1;
            while (num > 0)
            {
                tt *= num;
                num--;
                Console.WriteLine(tt);
            }
            Console.WriteLine(tt);
        }
    }
}
