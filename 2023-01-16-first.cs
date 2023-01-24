using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help2
{
    class RandomNum
    {

        Random rand = new Random();
        int randNum = 0;

        public void SetNum()
        {
            randNum = rand.Next(1, 101);
        }

        public int ReturnRandomNum()
        {
            return randNum;
        }
        

    }
}
