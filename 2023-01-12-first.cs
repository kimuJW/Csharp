using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help2
{
    class Count
    {
        int Num_Count = 0;

        public void DoCount()
        {
            Num_Count++;
        }

        public int ReturnCount()
        {
            return Num_Count;
        }

    }
}
