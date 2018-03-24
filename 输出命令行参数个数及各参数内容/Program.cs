using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 输出命令行参数个数及各参数内容
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("参数个数={0}",args.Length);//输出参数个数
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("Arg[{0}]=[{1}]",i,args[i]);//使用for语句输出各参数值
            }
            foreach (string s in args)//使用foreach输出各参数值
            {
                Console.WriteLine(s);
            }
        }
    }
}
