﻿using System;

namespace NASATime
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer();

            Console.WriteLine("Bitte geben Sie den Startwert des Countdowns ein.");
            timer.setStartingValue(int.Parse(Console.ReadLine()));

            Console.WriteLine("Countdown: " + timer.CountDown());
            Console.ReadKey();
        }
    }
}
