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
           Random su = new Random();
           int fix_su = su.Next(1,100);
           int count = 1;

           while(true){
            Console.Write("상대가 생각하는 수를 입력하시오 : ");
            int input_su = Convert.ToInt16(Console.ReadLine());
            if (fix_su < input_su){
                Console.WriteLine("너무 커");
                count++;
            }
            else if (fix_su > input_su)
            {
                Console.WriteLine("너무 작어");
                count++;
            }
            else
            {
                Console.WriteLine("정답");
                Console.WriteLine("랜덤값은 : " + fix_su);
                Console.WriteLine("시도횟수 =" + count);
                break;
            }
           }
        }
    }
}