﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace EventExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer();
            timer.Interval = 1000;
            Boy boy = new Boy();
            timer.Elapsed += boy.Action;
            timer.Start();
            Console.ReadLine();
        }
    }

    class Boy
    {
        internal void Action(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Jump");
        }
    }
}
