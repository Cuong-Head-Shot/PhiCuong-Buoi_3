using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static int BinarySearch(int[] array, int target)
    {
        int left = 0;
        int right = array.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            
            if (array[mid] == target)
                return mid;

           
            if (array[mid] < target)
                left = mid + 1;
           
            else
                right = mid - 1;
        }

    
        return -1;
    }

    static void Main()
    {
        int[] array = { 1, 3, 5, 7, 9, 11, 13, 15, 17 };
        int target = 11;

        Console.WriteLine("Mang ban dau:");
        PrintArray(array);

        int resultIndex = BinarySearch(array, target);

        if (resultIndex != -1)
            Console.WriteLine("\n" + target + " duoc tim thay tai vi tri index " + resultIndex);
        else
            Console.WriteLine("\n" + target + " khong ton tai trong mang");
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

