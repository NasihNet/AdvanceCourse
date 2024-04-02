using System;
using System.Threading;

namespace Threading
{
    internal class Program
    {   //thread = an execution path of a program
        //          we can use multiple thread to perform,
        //          different task of our program at the same time.
        //          Current thread running is main thread
        //          use system.threading
        static void Main(string[] args)
        {
            Thread mainThread = Thread.CurrentThread;

            // Assigning a name to the current thread
            mainThread.Name = "MainThread";

            // Accessing and printing the name of the main thread
            Console.WriteLine("Main thread name: " + mainThread.Name);
            Thread thread1 = new Thread(() => CountUp());
            Thread thread2 = new Thread(() => CountDown());
            thread1.Start();
            thread2.Start();
            Console.ReadLine();

        }



        public static void CountUp()
        {

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine( "Timer #1:" + i + "second");
                Thread.Sleep(1000);
            }
        
        
        }


        public static void CountDown()
        {

            for (int i = 100; i > 0; i--)
            {
                Console.WriteLine("Timer #2:" + i + "second");
                Thread.Sleep(1000);
            }


        }
    }
}