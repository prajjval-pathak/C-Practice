using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Exercise
{
    public class FbMsg
    {
        public void msg() { 
        var name=new List<string>();
            while (true)
            {
                Console.WriteLine("Enter names");
                var ct=Console.ReadLine();
                if (String.IsNullOrEmpty(ct))
                {
                    break;
                }
                else { 
                    name.Add(ct);
                }
            }
            if (name.Count == 0)
            {
                Console.WriteLine("you need to become popular asshole");

            }
            if (name.Count == 1)
            {
                Console.WriteLine(name[0] + " Liked your post");
            }
            if (name.Count == 2)
            {
                Console.WriteLine(name[0] + name[1] + "Liked your post");
            }
            if(name.Count>2) {
                Console.WriteLine(name[0] +" "+ name[2] + " and "+Convert.ToString(name.Count()-2)+" other Liked Your Post");
            }
        }
    }
}
