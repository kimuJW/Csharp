using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch10_가위바위보게임
{
    class c
    {
        public static string check_W_L(int man_su, int com_su) //가위 1 바위 2 보 3
        {
            string a = "";
            if (man_su == com_su)
            {
                a = "서로 비김";
            }
            else if (man_su == 1 && com_su == 2)
            {
                a = "내가 짐";
            }
            else if (man_su == 1 && com_su == 3)
            {
                a = "내가 이김";
            }
            else if (man_su == 2 && com_su == 1)
            {
                a = "내가 이김";
            }          
            else if (man_su == 2 && com_su == 3)
            {
                a = "내가 짐";
            }
            else if (man_su == 3 && com_su == 1)
            {
                a = "내가 짐";
            }
            else
            {
                a = "내가 이김";
            }           
            return a;
        }
    }
}
