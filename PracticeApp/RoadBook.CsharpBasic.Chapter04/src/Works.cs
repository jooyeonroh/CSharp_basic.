using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter04.src
{
    class Works
    {
        public void work001()
        {
            //구구단 2단
            int defNum = 2;
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("2 * {0} = {1}", i, defNum * i);
            }
        }
        public void work002()
        {
            //5!
            int defNum = 1;
            for (int i = 5; i > 0; i-- )
            {
                defNum *= i;
                Console.WriteLine("value ={0} ", defNum);
            }
        }
    }
}
