using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help2
{
    class Program
    {
        static void Main(string[] args)
        {
            int right = 0;
            Count mCount = new Count();
            RandomNum mRandomNum = new RandomNum();
            OutString mOutString = new OutString();
            calculate mCalculate = new calculate();

            //초기값 설정
            mRandomNum.SetNum();
            mCalculate.GetNum(mRandomNum.ReturnRandomNum());

            //랜덤값을 생성
            
            //입력을 받음
            
            //결과 출력

            while(true)
            {
                right = mCalculate.isRight();
                mCount.DoCount();
                mOutString.ConsoleOutString(right,mCount.ReturnCount(),mRandomNum.ReturnRandomNum());

                if (right == 3)
                    break;

            }


        }
    }
}
