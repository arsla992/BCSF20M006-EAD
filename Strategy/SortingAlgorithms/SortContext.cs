using StrategyDesignPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    public class SortContext
    {
        private ISortStrategy sortStrategy;

        public void SetSortStrategy(ISortStrategy strategy)
        {
            sortStrategy = strategy;
        }

        public void ExecuteSort(List<int> list)
        {
            sortStrategy.Sort(list);
        }
    }

}
