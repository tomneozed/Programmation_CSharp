﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstructionBreak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 101; i++)
            {
                Console.WriteLine(i);
                if (i == 25)
                {
                    break;
                }
            }
        }
    }
}
