using c_sharp_SortingAlgorithms;

internal class Program
{
    private static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 5, 2, 9, 1, 3 };

       

        List<int> sortedNumbers = BubbleSort.BubbleSortFun(numbers);

        Console.WriteLine("Sorted List:");
        foreach (int num in sortedNumbers)
        {
            Console.Write(num + " ");
        }
       
    }
}
