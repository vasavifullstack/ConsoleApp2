using System;
using System.Threading;
using System.Threading.Tasks;


namespace AsyncronousCallContainer
{
    class WorkItems
    {


        //Asynchrouns call
        public static async Task PrepareWordDocumentationAsync()
        {

            var starttime = DateTime.Now; //Present datetime.

            Console.WriteLine($" Started the the PPTs Presentation at {starttime}");
            // Thread.Sleep(2000);  //Code compiler is kind of thread telling that stay here 2 secs.
            await Task.Delay(2000); //task taking the 2secs

            var endtime = DateTime.Now; //Present datetime

            var elapsedTime = endtime - starttime; // 2secs

            Console.WriteLine($"Completed the Doucumentation Elapsed time: {elapsedTime} ms.");
        }


        public static async Task PreparePPTsPresentationAsync()
        {
            var startTime = DateTime.Now;
            //Here Prepare the PPTs is taking the 3 seconds. Actually it will take 1 day or 2 days but name saking i have taken 3 seconds : 🙂
            //Thread.Sleep(5000);  // incase 3000 means 3 seconds
            // Record end time
            Console.WriteLine($" Started the the PPTs Presentation at {startTime}");
            await Task.Delay(5000);
            var endTime = DateTime.Now;
            // Calculate elapsed time
            var elapsedTime = endTime - startTime;

            Console.WriteLine($"Completed the the PPTs Presentation: {elapsedTime} ms.");
        }

        public static async Task PrepareNotesAsync()
        {
            var startTime = DateTime.Now;
            //Here Prepare the notes is taking the 4 seconds. Actually it will take 1 day or 2 days but name saking i have taken 4 seconds : 🙂
            //Thread.Sleep(4000);  // incase 4000 means 4 seconds
            // Record end time
            Console.WriteLine($" Started the the PPTs Presentation at {startTime}");
            await Task.Delay(4000);

            var endTime = DateTime.Now;
            // Calculate elapsed time
            var elapsedTime = endTime - startTime;

            Console.WriteLine($"Completed the Notes: {elapsedTime} ms.");
        }


    }

    class Trainer
    {
        public static async Task Works()
        {
            /*****************For sequential order******************/
            Console.WriteLine("Sequential Works - Step By Step");

            // Record start time for sequential process
            var PrepartionStartTime = DateTime.Now;


            //await  WorkItems.PrepareWordDocumentationAsync();   // 2 secs

            //await  WorkItems.PreparePPTsPresentationAsync();   // 5 secs

            //await WorkItems.PrepareNotesAsync();               // 4 secs



            //Concurrenlty
            Task task1 = WorkItems.PrepareWordDocumentationAsync();
            Task task2 = WorkItems.PreparePPTsPresentationAsync();
            Task task3 = WorkItems.PrepareNotesAsync();

            await Task.WhenAll(task1, task2, task3);   //all tasks exeectuing concurrently




            //Task workdPrep =  WorkItems.PrepareWordDocumentationAsync();
            //WorkItems.PreparePPTsPresentation();    // 5 secs
            //WorkItems.PrepareNotes();               // 4 secs

            // Record end time for sequential downloading
            var preparationEndTime = DateTime.Now;

            // Calculate elapsed time for sequential downloading
            var sequentialElapsedTime = preparationEndTime - PrepartionStartTime;

            Console.WriteLine("Hello world");

            //Console.WriteLine($"Sequential downloading completed. Total elapsed time: {sequentialElapsedTime.TotalMilliseconds} ms.");

        }
    }

    class Program
    {
        static async Task Main()
        {
            await Trainer.Works();
        }
    }
}
