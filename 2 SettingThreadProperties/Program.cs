using System;
using System.Diagnostics;
using System.Threading;

public class Example
{
    public static void Main()
    {
        //initialize a thread class object 
        //And pass your custom method name to the constructor parameter

        Thread thread = new Thread(SomeMethod);

        thread.Name = "My Parallel Thread";

        thread.Priority = ThreadPriority.BelowNormal;

        //start running your thread

        thread.Start();

        Console.WriteLine("Press Enter to terminate!");
        Console.ReadLine();
    }

    private static void SomeMethod()
    {
        //your code here that you want to run parallel
        //most of the cases it will be a CPU bound operation

        Console.WriteLine("Hello World!");
    }
}