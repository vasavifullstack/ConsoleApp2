using System;

class Programs
{
    static void Main()
    {
        int result;  // no need to initialize
        Calculate(out result);

        Console.WriteLine(result); // Output: 50
    }

    static void Calculate(out int value)
    {
        value = 50; // must assign before method ends
    }
    

}
