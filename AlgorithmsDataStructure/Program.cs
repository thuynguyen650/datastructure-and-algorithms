namespace AlgorithmsDataStructure;

public class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 64, 25, 12, 22, 11 };

        ArraySorting.SelectionSort(arr);

        foreach (int i in arr)
        {
            Console.WriteLine(i);
        }
    }
}
