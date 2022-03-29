using Algorithms.Sorting;

namespace Algorithms;

public class Program
{
    static void Main(string[] args)
    {
        int[] arr = {1, 10, 6, 3, 4};
        SelectionSort.Sort(arr);
        for (var i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    } 
}
