using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch1
{
    class Test
    {
        static void Main(string[] args)
        {
            Console.Write("하나의 수 s1 입력: ");
            string s1 = Console.ReadLine();
            Console.Write("또 하나의 수 s2 입력: ");
            string s2 = Console.ReadLine();
            int a = int.Parse(s1);
            int b = int.Parse(s2);
            int c = a + b;
            Console.WriteLine("s1과 s2의 합은 = " + c);                 
        }
    }
}