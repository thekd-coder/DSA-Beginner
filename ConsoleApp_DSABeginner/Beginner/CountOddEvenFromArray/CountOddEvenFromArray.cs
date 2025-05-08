//Read 'ReadMe.md' file present in the folder which name is same as this class's name

namespace ConsoleApp_DSABeginner.Beginner.CountOddEvenFromArray
{
    internal class CountOddEvenFromArray
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
