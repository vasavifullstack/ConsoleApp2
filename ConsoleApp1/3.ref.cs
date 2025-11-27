using System;

class Program
{
    static void Main()
    {
        int number = 10;
        ModifyRef(ref number);

        Console.WriteLine(number);  // Output: 20
    }

    static void ModifyRef(ref int x)
    {
        x = x * 2; // modifies original value
    }
}
