using Lab3;

int[] array = { 1 };

SortingService sortingContext = new SortingService(new BubbleSortStrategy());
sortingContext.SortArray(array);

sortingContext.SetStrategy(new QuickSortStrategy());
sortingContext.SortArray(array);
