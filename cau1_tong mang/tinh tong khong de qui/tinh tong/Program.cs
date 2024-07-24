using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SumFromArray1ToN
{
    public class Program
    {
        
        static int SumFrom1ToN(int n)
        {
            
            int sum = n * (n + 1) / 2;
            return sum;
        }

        public static void Main(string[] args)
        {
            
            Console.Write("Nhập số nguyên dương n: ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Vui lòng nhập lại số nguyên dương n: ");
            }

          
            int result = SumFrom1ToN(n);

           
            Console.WriteLine("Tổng từ 1 đến " + n + " là: " + result);
            Console.ReadLine();
        }
    }
}





