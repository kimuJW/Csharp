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
            Console.Write("문자열 s1 입력: ");
            string s1 = Console.ReadLine();
            Console.Write("문자열 s2 입력: ");
            string s2 = Console.ReadLine();
            string s3 = s1 + s2;
            Console.WriteLine("s1과 s2의 합은 = " + s3);                 
        }
    }
}