using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionDemo
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Starting program...");

                // 1. NULL REFERENCE EXCEPTION
                string name = null;
                Console.WriteLine(name.Length);   // ❌ NullReferenceException

                // 2. DIVIDE BY ZERO EXCEPTION
                int x = 10;
                int y = 0;
                int result = x / y;              // ❌ DivideByZeroException

                // 3. INDEX OUT OF RANGE
                int[] arr = { 10, 20 };
                Console.WriteLine(arr[5]);       // ❌ IndexOutOfRangeException

                // 4. FORMAT EXCEPTION
                int number = int.Parse("ABC");   // ❌ FormatException

                // 5. FILE NOT FOUND
                string data = File.ReadAllText("noFile.txt"); // ❌ FileNotFoundException

                // 6. INVALID OPERATION
                List<int> nums = new List<int>();
                var item = nums[0];              // ❌ InvalidOperationException
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("❌ NullReferenceException occurred.");
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("❌ Cannot divide by zero!");
                Console.WriteLine(ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("❌ Index is out of range!");
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("❌ Input format is not valid!");
                Console.WriteLine(ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("❌ File not found!");
                Console.WriteLine(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("❌ Invalid operation!");
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("❌ Argument passed is not valid!");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                // Catches any OTHER exception not listed above
                Console.WriteLine("❌ General exception occurred!");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("✔ Finally block executed (cleanup).");
            }

            Console.WriteLine("Program continues after exception handling...");
        }
    }
}
