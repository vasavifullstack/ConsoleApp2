using System;
using System.Threading;


namespace SynchronousCallsContainer
{


    #region
    /* What is Synchrous call ?
       * A : Synchronous call means that the program will wait for the method to complete before moving on to the next line of code.
      */
    #endregion

    class WorkItems
    {

        /// <summary>
        ///  Prepare the word documentation . Now preparting word documention taking 2 ses.
        /// </summary>
        public static void PrepareWordDocumentation()
        {

            var starttime = DateTime.Now; //Present datetime.

            Thread.Sleep(2000);  //Code compiler is kind of thread telling that stay here 2 secs.

            var endtime = DateTime.Now; //Present datetime

            var elapsedTime = endtime - starttime; // 2secs

            Console.WriteLine($"Completed the Doucumentation Elapsed time: {elapsedTime} ms.");
        }

        /// <summary>
        /// Prepare the word documentation . Now preparting PPT documention taking 5 ses.
        /// </summary>
        public static void PreparePPTsPresentation()
        {
            var startTime = DateTime.Now;
            //Here Prepare the PPTs is taking the 3 seconds. Actually it will take 1 day or 2 days but name saking i have taken 3 seconds : 🙂
            Thread.Sleep(5000);  // incase 3000 means 3 seconds
            // Record end time
            var endTime = DateTime.Now;
            // Calculate elapsed time
            var elapsedTime = endTime - startTime;

            Console.WriteLine($"Completed the the PPTs Presentation: {elapsedTime} ms.");
        }

        /// <summary>
        /// Prepare the word documentation . Now preparting word documention taking 4 ses.
        /// </summary>
        public static void PrepareNotes()
        {
            var startTime = DateTime.Now;
            //Here Prepare the notes is taking the 4 seconds. Actually it will take 1 day or 2 days but name saking i have taken 4 seconds : 🙂
            Thread.Sleep(4000);  // incase 4000 means 4 seconds
            // Record end time
            var endTime = DateTime.Now;
            // Calculate elapsed time
            var elapsedTime = endTime - startTime;

            Console.WriteLine($"Completed the Notes: {elapsedTime} ms.");
        }

    }
    class Program
    {
        public static void Main()
        {
            Trainer.Works();
            Console.ReadLine();
        }
    }


    class Trainer
    {
        public static void Works()
        {
            /*****************For sequential order******************/
            Console.WriteLine("Sequential Works - Step By Step");

            // Record start time for sequential process
            var PrepartionStartTime = DateTime.Now;

            WorkItems.PrepareWordDocumentation();   // 2 secs
            WorkItems.PreparePPTsPresentation();    // 5 secs
            WorkItems.PrepareNotes();               // 4 secs

            // Record end time for sequential downloading
            var preparationEndTime = DateTime.Now;

            // Calculate elapsed time for sequential downloading
            var sequentialElapsedTime = preparationEndTime - PrepartionStartTime;
            Console.WriteLine($"Sequential downloading completed. Total elapsed time: {sequentialElapsedTime.TotalMilliseconds} ms.");

        }
    }


}
