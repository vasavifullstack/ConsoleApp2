using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathContainer
{
    class Program
    {
        // 10, 13
        // 10 is even
        // 13 is add

        // Method that processes an integer array and returns a string array
        static string[] ProcessArray(int[] numbers) // [10 ,13]
        {

            //string[] results = new string[3];
            //{ "abc" , "def , "xyz"} 
            // Create a string array to store results
            string[] results = new string[numbers.Length];

            // Loop through the input array
            for (int i = 0; i < numbers.Length; i++)
            {

                if (numbers[i] % 2 == 0)
                {
                    results[i] = $"{numbers[i]} is Even";
                }
                else
                {
                    results[i] = $"{numbers[i]} is Odd";
                }
            }

            //return string arrray
            return results;
        }

        static void Main()
        {
            int[] numbers = { 10, 13 };
            string[] output = ProcessArray(numbers);

            foreach (string result in output)
            {
                Console.WriteLine(result);
            }

            // Console.WriteLine(output);

        }
    }


}
