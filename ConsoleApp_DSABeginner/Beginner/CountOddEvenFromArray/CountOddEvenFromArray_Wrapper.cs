using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_DSABeginner.Beginner.CountOddEvenFromArray
{
    public class CountOddEvenFromArray_Wrapper
    {
        private CountOddEvenFromArray count = new CountOddEvenFromArray();
        private uint[] _array;
        public CountOddEvenFromArray_Wrapper(uint[] array)
        {
            _array = array;
        }
        public uint CalculateCount(bool oddEven)
        {
            count.CountOddEven(_array);

            if (oddEven)
            {
                return count._oddCount;
            }
            {
                return count._evenCount;
            }
        }
    }
}
