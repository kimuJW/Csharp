using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch1
{
    class Test
    {
        while(true)
        {
            Console.Write("상대가 생각하는 수를 입력하시오: ");
            int input_su = Convert.ToInt16(Console.ReadLine());
            if (fix_su < input_su)
            {
                Console.WriteLine("너무 커");
            }
            else if (fix_su > input_su)
            {
                Console.WriteLine("너무 작어");
            }
            else
            {
                Console.Write("정답");
                break;
            }
        }
    }
}