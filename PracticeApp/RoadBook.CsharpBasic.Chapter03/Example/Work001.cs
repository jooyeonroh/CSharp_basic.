using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter03.Example
{
    class Work001
    {
        public void Run()
        {
            Console.WriteLine("숫자를 입력해주세요");
            int intInput = Convert.ToInt32(Console.ReadLine());

            if (intInput == 0)
            {
                Console.WriteLine("0 이쥬?");
            }
            else if (intInput > 1)
            {
                Console.WriteLine("양수쥬?");
            }
            else
            {
                Console.WriteLine("음수쥬?");
            }

            if(intInput % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }


        }
    }
}
