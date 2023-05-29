namespace Lab3
{
    internal interface ISortingStrategy
    {
        void Sort(int[] array);
    }

    internal class BubbleSortStrategy : ISortingStrategy
    {
        public void Sort(int[] array)
        {
            Console.WriteLine("Sorting array using Bubble Sort");
        }
    }

    internal class QuickSortStrategy : ISortingStrategy
    {
        public void Sort(int[] array)
        {
            Console.WriteLine("Sorting array using Quick Sort");
        }
    }

    internal class SortingService
    {
        private ISortingStrategy strategy;

        public SortingService(ISortingStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void SetStrategy(ISortingStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void SortArray(int[] array)
        {
            strategy.Sort(array);
        }
    }

}
