using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types_and_Ranges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //this for loop will loop from 0 to the max value of int, then overflow to the min value of int, but I set the number higher so this can be seen earlier
            for (int i = 2147383647; i <= int.MaxValue; i++)
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }
}
