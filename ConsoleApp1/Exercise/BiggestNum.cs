using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Exercise
{
    public class BiggestNum
    {
       public void biggestnum() {
            var li = new List<int>();
            Console.WriteLine("Enter total number of elements in list");
            var pt = Console.ReadLine();
            for (var i = 0; i < Convert.ToInt32(pt); i++)
            {
                Console.Write("enter " + Convert.ToString(i + 1) + " element ");
                var f = Convert.ToInt32(Console.ReadLine());
                li.Add(f);
            }
            Console.WriteLine("largest element in list is " + li.Max());
        }
    }
}
