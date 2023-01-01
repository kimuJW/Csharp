using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2_Method
{
    class Class1
    {
    
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;
            int hap = Plus.Sum(a, b);
            Console.WriteLine("a+b={0}",hap);

        }
        //public class Plus
        //{
        //    public static int Sum(int a1, int b1)
        //    {
        //        int tot;
        //        tot = a1 + b1;
        //        return tot;
        //    }


        //}


    }
}
