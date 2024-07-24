using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static int BinarySearchRecursive(int[] array, int target, int left, int right)
    {
        if (left > right)
            return -1;

        int mid = left + (right - left) / 2;

        if (array[mid] == target)
            return mid;
        else if (array[mid] < target)
            return BinarySearchRecursive(array, target, mid + 1, right);
        else
            return BinarySearchRecursive(array, target, left, mid - 1);
    }

    static void Main()
    {
        int[] array = { 1, 3, 5, 7, 9, 11, 13, 15, 17 };
        int target = 15;

        Console.WriteLine("Mang ban dau:");
        PrintArray(array);

        
        int resultIndex = BinarySearchRecursive(array, target, 0, array.Length - 1);

        if (resultIndex != -1)
            Console.WriteLine("\n" + target + " duoc tim thay tai vi tri index " + resultIndex);
        else
            Console.WriteLine("\n" + target + " khong ton tai trong mang");
        Console.ReadLine();
    }

    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
        Console.ReadLine();
    }
}

