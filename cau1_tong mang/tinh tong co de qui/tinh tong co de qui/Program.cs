using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumArrayRecursively
{
    class Program
    {
      
        static int SumRecursive(int n)
        {
            
            if (n == 0)
                return 0;
          
            return SumRecursive(n - 1) + n;
        }

        static void Main(string[] args)
        {
          
            Console.Write("Nhập số nguyên dương n: ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Vui lòng nhập lại số nguyên dương n: ");
            }

            
            int result = SumRecursive(n);

          
            Console.WriteLine("Tổng từ 1 đến " + n + " là: " + result);
            Console.ReadLine();
        }
    }
}

