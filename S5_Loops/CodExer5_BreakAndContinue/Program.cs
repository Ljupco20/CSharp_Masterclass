﻿using System;

namespace CodExer5_BreakAndContinue
{
    internal class Program
    {
        static void Main(string[] args)
        {
             int i = -10;
            
            while(true)
            {
                 
             if (i%3==0)
                {
                    i++;
                    continue;
                }
                if (i == 10)
                    break;
                Console.WriteLine(i++);    
              
              
            }
              Console.ReadLine();
              
        }
    }
}
