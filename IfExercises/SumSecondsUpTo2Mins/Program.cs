﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var num3 = int.Parse(Console.ReadLine());
            var seconds = num1 + num2 + num3;
            var minutes = 0; 

            if (seconds >= 60)
            {
                minutes =minutes + 1;
                seconds =seconds - 60;
            }

            if (seconds >= 60)
            {
                minutes = minutes + 1;
                seconds = seconds - 60;
            }

            if (seconds < 10)
            {
                Console.WriteLine(minutes + ":0" + seconds);
            }
            else
            {
                Console.WriteLine("{0}:{1}", minutes, seconds);
            }
        }
    }
}