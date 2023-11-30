


using StrategyDesignPattern;

public class SortingAlgorithms
{
    public static void Main(string[] args)
    {
        // Creating a sorting context
        SortContext sortContext = new SortContext();

        // Using Bubble Sort strategy
        sortContext.SetSortStrategy(new BubbleSort());
        List<int> numbers1 = new List<int> { 5, 2, 8, 1, 7 };
        sortContext.ExecuteSort(numbers1);

        // Using Quick Sort strategy
        sortContext.SetSortStrategy(new QuickSort());
        List<int> numbers2 = new List<int> { 10, 3, 6, 4, 9 };
        sortContext.ExecuteSort(numbers2);
    }
}
