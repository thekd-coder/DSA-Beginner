using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_DSABeginner.Beginner.CountOddEvenFromArray
{
    public class CountOddEvenFromArray
    {
        public uint _oddCount { get; set; }
        public uint _evenCount { get; set; }


        public void CountOddEven(uint[] Array)
        {
            foreach (uint number in Array)
            {
                if(number % 2 == 0)
                {
                    _evenCount++;
                }
                else
                {
                    _oddCount++;
                }
            }
        } 
    }
}
