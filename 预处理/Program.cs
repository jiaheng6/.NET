#define DEBUG
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 预处理
{
    class Program
    {
        static void Main(string[] args)
        {
            #if (DEBUG)
            #line 200 "special"//修改行号
            #warning DEBUG is defined!、

            #endif
        }
    }
}
