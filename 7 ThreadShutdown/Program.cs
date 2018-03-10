using System;
using System.Diagnostics;
using System.Threading;

public class Example
{
    //set to volatile as its liable to change so we JIT to don't cache the value
    private static volatile bool _cancel = false;

    public static void Main()
    {
        //initialize a thread class object 
        //And pass your custom method name to the constructor parameter

        Thread t = new Thread(Speak);

        //start running your thread
        //dont forget to pass your parameter for the Speak method (ParameterizedThreadStart delegate) in start method
        t.Start("Hello World!");

        //wait for 5 secs while Speak method print Hello World! for multiple times
        Thread.Sleep(5000);

        //signal thread to terminate
        _cancel = true;


        //wait until CLR confirms that thread is shutdown
        t.Join();
    }

    private static void Speak(object s)
    {

        while (!_cancel)
        {
            string say = s as string;
            Console.WriteLine(say);
        }

    }
}