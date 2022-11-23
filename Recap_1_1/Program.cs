using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap_1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create an array that holds values up to 350,
            // where each position is calculated as such:
            // consider position k and array[k] = (array[k-2] + array[k-1]) * 2
            // assume array[0] = 1 and array[1] = 3

            int[] array = new int[] { 1, 3 };
            // Step 1. Initialise counter
            int counter = 2;

            // Step 2. Calculate sum
            int sum = (array[counter - 2] + array[counter - 1]) * 2;

            // Step 3. για όσο το sum <= 350
            while(sum <= 350)
            {
                array = array.Append(sum).ToArray();
                // Step 4. counter++;
                counter++;

                // Step 5. calculate sum
                sum = (array[counter - 2] + array[counter - 1]) * 2;
            }
            
            // print array
            for(int j = 0; j < array.Length; j++)
            {
                Console.WriteLine(array[j]);
            }
        }
    }
}
