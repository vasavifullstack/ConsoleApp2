using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptionContainer
{


    //Practece class with constructor

    // 2 types  Defining ---> how to call the class memeers , methods , properities , constructors 



    class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message) : base(message)
        {
        }

    }

    class Programs
    {
        public static void ValidateAge(int age)
        {
            if (age < 18 || age > 60)
            {
                throw new InvalidAgeException($"Invalid age {age} . Age must be between the 18 to 60");
                // throw new NullReferenceException();
            }
            else
            {
                Console.WriteLine($"Age {age} is valid for this process.");
            }
        }
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter your age:");
                //int age = int.Parse(Console.ReadLine());  // 10
                int age = 10; // hot coded value

                ValidateAge(age);
            }
            catch (InvalidAgeException ex)
            {
                string message = ex.Message;
                Console.WriteLine($"Custom Exception Caught: {message}");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"YOur value is null");
            }
            finally
            {
                Console.WriteLine("validtion proces completed");
            }
            //catch(Exception ex)
            //{

            //}


        }
    }
}



// 18-60 eliable     -- 10 , 70  