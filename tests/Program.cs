using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tests
{
    class Program
    {
        static void Main(string[] args)
        {
        int res=Test.Calculate(15, 4);
       
        }
    }
static class Test
    {
        public static int Calculate(int a,int b)
        {
            return a * b;
        }
    }
}
