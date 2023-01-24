using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help2
{
    class OutString
    {

        public void ConsoleOutString(int num, int count, int randnum)
        {
            switch (num)
            {
                case 1:
                    Console.WriteLine("입력값이 더 큽니다.");
                    break;
                case 2:
                    Console.WriteLine("입력값이 작습니다.");
                    break;
                case 3:
                    Console.WriteLine("입력값이 동일합니다.");
                    break;
                default:
                    break;
            }
        }
    }
}
