using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace 正则表达式
{
    class Program
    {
        static void Main(string[] args)
        {
            //var s1 = "abc";
            //var pattern = "abc";
            //Console.WriteLine(Regex.IsMatch(s1,pattern));//True
            //（1）Regex r = new Regex(/*要匹配的正则表达式模式*/);
            //（2）Regex r = new Regex(/*要匹配的正则表达式模式*/,/*用于修改正则表达式的枚举值的按位组合*/);
            //（3）Regex r = new Regex(/*要匹配的正则表达式模式*/,/*用于修改正则表达式的枚举值的按位组合*/,/*匹配的超时时间*/);
            string[] values = { "111-22-3333","111-2-3333"};
            string pattern = @"^\d{3}-\d{2}-\d{4}$";//“^\d{3}”表示以重复三次的数字开头，“\d{4}$”表示以重复四次的数字结尾
            foreach (var value in values)
            {
                if (Regex.IsMatch(value,pattern))
                {
                    Console.WriteLine("{0} is valid",value);
                }
                else
                {
                    Console.WriteLine("{0} is not valid",value);
                }
                //运行结果可以匹配到第一个字符串，第二个匹配不到

            }
        }
    }
}
