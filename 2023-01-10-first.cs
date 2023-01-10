using System;

namespace GBB
{
    class Program
    {
        public static int fix_su = 0;
        public static int input_su = 0;

        static void Main(string[] args)
        {
          
                Random su = new Random();
                fix_su = su.Next(1, 100);
                int count = 0;
                while (true)
                {
                    Console.WriteLine("상대가 생각하는 수를 입력하시오: ");
                    input_su = Convert.ToInt16(Console.ReadLine());
                    count++;
                
                
                Console.WriteLine(GBB.Enter());
                
                if (GBB.Enter() == "정답")
                {
                    Console.WriteLine("시행 횟수는 {0}", count);
                    break;
                }
                
            
            
            }

            }
        }
    }

