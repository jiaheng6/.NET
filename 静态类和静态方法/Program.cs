using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 静态类和静态方法
{
    class Program
    {
        static int num = 10;
        static void Main(string[] args)
        {
            num = 100;
            Console.WriteLine(num);
            Show();
            //Convert就是一个静态类
        }
        static void Show() 
        {
            Console.WriteLine(num);
        }
    }
}
