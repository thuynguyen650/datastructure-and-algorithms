namespace AlgorithmsDataStructure;

public class ArraySearching
{
    public static int LinearSearch(int[] arr, int x)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
            {
                return i;
            }
        }
        return -1;
    }

    public static int BinarySearch(int[] arr, int x)
    {
        int l = 0;
        int r = arr.Length - 1;
        while (l <= r)
        {
            int mid = l + (r - l) / 2;
            if (arr[mid] == x)
            {
                return mid;
            }    
            if (arr[mid] > x)
            {
                r = mid - 1;
            } else
            {
                l = mid + 1;
            }
        }
        return -1;
    }

    public static int RecursiveBinarySearch(int[] arr, int l, int r, int x)
    {
        if (l <= r)
        {
            int mid = l + (r - l) / 2;
            if (arr[mid] == x)
            {
                return mid;
            }
            if (arr[mid] > x)
            {
                return RecursiveBinarySearch(arr, l, mid - 1, x);
            } else
            {
                return RecursiveBinarySearch(arr, mid + 1, r, x);
            }
        }
        return -1;
    }
}
