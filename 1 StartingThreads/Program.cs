using System;
using System.Diagnostics;
using System.Threading;

public class Example
{
    public static void Main()
    {
        //initialize a thread class object 
        //And pass your custom method name to the constructor parameter
        Thread t = new Thread(SomeMethod);

        //start running your thread
        t.Start();

        //while thread is running in parallel you can carry out other operations here

        //wait until Thread "t" is done with its execution.
        t.Join();

        Console.WriteLine("Press Enter to terminate!");
        Console.ReadLine();
    }

    private static void SomeMethod()
    {
        //your code here that you want to run parallel
        //most of the time it will be a CPU bound operation

        Console.WriteLine("Hello World!");
    }
}