using System;

namespace Max
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("1 하나의 수 입력: ");
            int input = Convert.ToInt16(Console.ReadLine());
            Console.Write("2 하나의 수 입력: ");
            int input2 = Convert.ToInt16(Console.ReadLine());
            Console.Write("3 하나의 수 입력: ");
            int input3 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("최댓값은 {0} ",Compare.Comp(input, input2, input3));
            Console.WriteLine("최소값은 {0} ", Compare2.Comp2(input, input2, input3));
        }
    }
}
