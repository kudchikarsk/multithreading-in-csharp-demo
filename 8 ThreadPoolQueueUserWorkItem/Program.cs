using System;
using System.Threading;

class Example1
{
    public static void Main()
    {
        // call QueueUserWorkItem to queue your work item
        ThreadPool.QueueUserWorkItem(Speak);

        Console.WriteLine("Press Enter to terminate!");
        Console.ReadLine();
    }

    //your custom method you want to run in another thread
    public static void Speak(object stateInfo)
    {
        // No state object was passed to QueueUserWorkItem, so stateInfo is null.
        Console.WriteLine("Hello World!");
    }
}