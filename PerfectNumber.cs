using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectNumber
{
    internal class PerfectNumber
    {
        public static void DisplayPerfectNumber() 
        {
            int n, max, min, sum, i;
            Console.WriteLine("Enter the Starting value :");
            min=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Ending value :");
            max = Convert.ToInt32(Console.ReadLine());
            for(n=min; n<=max; n++) 
            
            
          {
                sum = 0;
                i=1;
                while (i < n) 
                {
                    if(n%i== 0)
                    sum = sum + i;
                    i++;
                }
                if(sum == n)
                {
                    Console.WriteLine("The perfect number is :"+n);
                }
            }

        }
    }
}
