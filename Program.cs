using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveThirty
{
    class Program
    {
        static void Main(string[] args)
        {
            string itIsOrNot = null;

            int currentHour = DateTime.Today.Hour;
            int currentMinute = DateTime.Today.Hour;

            if(currentHour == 5 && currentMinute == 30)
            {
                itIsOrNot = "It is 5:30!";
                Console.WriteLine(itIsOrNot);
            }
            else
            {
                itIsOrNot = "It is not 5:30! :(";
                Console.WriteLine(itIsOrNot);
            }
            Console.ReadKey();
        }
    }
}
