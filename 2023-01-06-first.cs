using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch10_가위바위보게임
{
    class Program
    {
        static void Main(string[] args)
        {
            int man_su = 0; int cnt = 0; int ga = 0; int ba = 0;
            int bo = 0; int my_w = 0; int my_l = 0; int my_d = 0;
            while (true)
            {
                Console.WriteLine("1 , 2,  3 중 하나의 수 입력: ");
                Random Number = new Random();
                int com_su = Number.Next(1, 4);
                man_su = Convert.ToInt32(Console.ReadLine());
                if (man_su == -1) break; cnt++;
                string result = c.check_W_L(man_su, com_su);
                Console.WriteLine(result);
                Console.WriteLine("컴의 선택은 {0}", com_su);
                Console.WriteLine("-------------------------------------");
                b.computer_su(ref ga, ref ba, ref bo, com_su);
                a.my_w_l_d(ref my_w, ref my_l, ref my_d, result);
            }
            Console.WriteLine();
            Console.WriteLine("총 게임 횟수 {0} 번 ", cnt);
            Console.WriteLine("컴의 가위 = {0}, 컴의 바위 = {1} , 컴의 보 = {2} ", ga, ba, bo);
            Console.WriteLine("서로비김= {0}, 내가 승 = {1} , 내가 패 = {2}", my_d, my_w, my_l);
        }          
    }
}
