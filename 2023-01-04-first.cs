using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch10_가위바위보게임
{
    class b
    {
      public static void computer_su(ref int ga, ref int ba, ref int bo, int com_su) //컴퓨터가 뭘 냈는지
        {
            if (com_su == 1)
            {
                ga++;
            }
            else if (com_su == 2)
            {
                ba++;
            }
            else
                bo++;
        }
    }
}
