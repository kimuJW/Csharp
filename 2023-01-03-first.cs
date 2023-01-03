using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch10_가위바위보게임
{
    public class a
    {
        public static void my_w_l_d(ref int my_w, ref int my_l, ref int my_d, string result)
        {
            if (result == "내가 이김")
            {
                my_w++;
            }
            else if (result == "내가 짐")
            {
                my_l++;
            }
            else
                my_d++;
        }
    }
}
