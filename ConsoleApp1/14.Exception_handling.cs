using System;
using System.Collections.Generic;

namespace ExceptionHanlding
{

    /*
 * 
An Exception is an unexpected issue that occurs in a program, preventing it from executing as intended. 
It can happen due to coding mistakes, system failures, or invalid user inputs, requiring correction to proceed

Types of Exceptions: Exceptions in C# can be of various types, such as System.Exception, System.ArgumentException, System.NullReferenceException, etc. Each exception type represents a specific kind of error that may occur during program execution.

Try-Catch Blocks: Exception handling in C# is typically done using try-catch blocks. The try block contains the code that may throw an exception, and the catch block handles the exception if one occurs.

  Syntax :
    try
    {
        // Code that may throw an exception
    }
    catch (Exception ex)
    {
        // Handle the exception
        Console.WriteLine($"An error occurred: {ex.Message}");
    }
    finally{
     
    }

 */
    class CarFeatures
    {
        public string FuelStatus { get; set; }
        public string EngineStatus { get; set; }
    }


    // A  --- A
    class Program
    {
        static void CustomerWork(CarFeatures carFeatures)
        {
            string carFuelStatus = carFeatures.FuelStatus;
            string carEngineStatus = carFeatures.EngineStatus;



            if (carFuelStatus == "Full" && carEngineStatus == "Fine")
            {
                Console.WriteLine("Customer is driving the car");
            }

            else
            {
                //carFuelStatus   = carFuelStatus ?? "unknown";
                //carEngineStatus = carEngineStatus ?? "unknown";
                try
                {


                    //throw new NullReferenceException();  // manually u r telling to the compleier plz excutes.


                    carFuelStatus = carFuelStatus.Replace(carFuelStatus, "Empty");
                    carEngineStatus = carEngineStatus.Replace(carEngineStatus, "Bad");
                    Console.WriteLine($"Customer car has issue {carFuelStatus} , {carEngineStatus}");


                    ////hot coded values....
                    ////string[] names = new string[2];
                    ////names[0] = "John";
                    ////names[1] = "Robert";
                    ////names[2] = "Martin";

                    //var list = new List<int> { 10, 20, 30 };
                    //int tenthNumber = list[10];

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Server is donw . pLease try again after some time..");
                }
                finally
                {
                    Console.WriteLine("Exception handled  has occureded");
                }
                //catch (NullReferenceException ex)
                //{
                //    Console.WriteLine($"Ysour input(s) are not valid... Please re-check again and your expcetion message is {ex.Message}");
                //}
                //catch (IndexOutOfRangeException ex)
                //{
                //    Console.WriteLine($"Your input(s) are crossed more than the index and your issue is: {ex.Message}");
                //}
                //catch (ArgumentOutOfRangeException ex)
                //{
                //    Console.WriteLine($"Your input(s) are crossed more than the index and your issue is: {ex.Message}");
                //}

                Console.WriteLine("Hello world ... what are you doing .....Code has executed");
            }




        }

        static void Main()
        {

            //First customer
            //string UserInputFuelStatus = "Full";
            //string UserInputEngineStatus = "Fine";

            //Second Customer
            //string UserInputFuelStatus = "Not-Full";
            //string UserInputEngineStatus = "Not-Good";


            string UserInputFuelStatus = "Not-Full";
            string UserInputEngineStatus = "Not-Good";


            CarFeatures carFeatures = new CarFeatures
            {
                FuelStatus = UserInputFuelStatus,
                EngineStatus = UserInputEngineStatus
            };

            CustomerWork(carFeatures);
        }
    }
}