using System;
using System.Threading;

class Example1
{
    public static void Main()
    {
        // call QueueUserWorkItem to queue your work item
        ThreadPool.QueueUserWorkItem(Speak, "Hello World!");

        Console.WriteLine("Press Enter to terminate!");
        Console.ReadLine();
    }

    //your custom method you want to run in another thread
    public static void Speak(object s)
    {
        string say = s as string;
        Console.WriteLine(say);
    }
}