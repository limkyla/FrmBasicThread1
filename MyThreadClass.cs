﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FrmBasicThread1
{
    internal class MyThreadClass
    {
        public static void Thread1()
        {
            for (int loopCount = 0; loopCount <= 5; loopCount++)
            {
                Thread thread = Thread.CurrentThread;
                Thread.Sleep(1000);
                Console.WriteLine($"Name of Thread: {thread.Name} = {loopCount}");
            }
        }
    }
}
