using c_sharp_SortingAlgorithms;

internal class Program
{
    private static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 5, 2, 9, 1, 3 };

       

        List<int> sortedNumbers = BubbleSort.BubbleSortFun(numbers);

        Console.WriteLine("Sorted List using BubbleSort:");
        foreach (int num in sortedNumbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        List<int> sortedNumberssel = SelectionSort.SelectionSortFun(numbers);

        Console.WriteLine("Sorted List using SelectionSort:");
        foreach (int num in sortedNumberssel)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        List<int> sortedNumbermerg = MergeSort.MergeSortFun(numbers);

        Console.WriteLine("Sorted List using MergeSort:");
        foreach (int num in sortedNumbermerg)
        {
            Console.Write(num + " ");
        }

    }
}
