using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help2
{
    class calculate
    {

        int GetRandNum = 0;

        public int isRight()
        {
            int GetInput;
            GetInput = int.Parse(Console.ReadLine());
            if(GetInput > GetRandNum)
            {
                return 1;
            }
            else if(GetInput < GetRandNum)
            {
                return 2;
            }
            else
            {
                return 3;
            }

        }

        public void GetNum(int tmp)
        {
            GetRandNum = tmp;
        }

    }
}
