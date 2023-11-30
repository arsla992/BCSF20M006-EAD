using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    public class BubbleSort : ISortStrategy
    {
        public void Sort(List<int> list)
        {
            Console.WriteLine("Bubble Sort");
        }
    }
}
