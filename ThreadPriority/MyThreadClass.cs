using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadPriorityy
{
    public class MyThreadClass
    {
        public static void Thread1()
        {
            for (int loopCount = 0; loopCount < 2; loopCount++)
            {
                Thread.Sleep(500);
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + loopCount);
            }
        }


        public static void Thread2()
        {
            for (int loopCount = 0; loopCount < 6; loopCount++)
            {
                Thread.Sleep(1500); // Suspend for 1.5 seconds
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + loopCount);
            }
        }
    }
}