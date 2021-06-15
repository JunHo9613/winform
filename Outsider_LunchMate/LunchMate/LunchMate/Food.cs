using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LunchMate
{
    class Food
    {
        public string food { get; set; }
        public int vote { get; set; }
        
        public void printAllFood()
        {
            Console.WriteLine($"{food} : {vote}");
        }
    }
}
