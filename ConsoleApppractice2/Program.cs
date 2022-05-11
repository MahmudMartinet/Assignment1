using System;

namespace ConsoleApppractice2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            int num4 = Convert.ToInt32(Console.ReadLine());
            int num5 = Convert.ToInt32(Console.ReadLine());
            int num6 = Convert.ToInt32(Console.ReadLine());
            int num7 = Convert.ToInt32(Console.ReadLine());
            int num8 = Convert.ToInt32(Console.ReadLine());
            int num9 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(GetMax(num1, num2, num3, num4, num5, num6, num7, num8 ));


            Console.ReadLine();
        }
        static int GetMax(int num1, int num2)
        {
            int result;
            if (num1 > num2)
            {
                result = num1;
            }
            else
            {
                result = num2;
            }


            return result;
        }
        
        
           
        
    }
}
