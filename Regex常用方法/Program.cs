using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regex常用方法
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "This is jikexueyuan jikexueyuan !";
            var pattern = @"\b(\w+)\W(\1)\b";
            Match match = Regex.Match(input, pattern);//用正则表达式match的方式获得字符串中的一段
            while (match.Success)
            {
                Console.WriteLine("Duplication {0} found",match.Groups[1].Value);
                match = match.NextMatch();
            }
            /*----------替换字符串中的一位-----------*/
            RegexReplace();
            /*---------------分割字符串的效果------------------------*/
            RegexSplit();
        }
        /// <summary>
        /// 替换一个字符串
        /// </summary>
        private static void RegexReplace() 
        {
            string pattern = @"\b\d+\.\d{2}\b";
            //首先是一个单词的开始，然后是一个数字，且至少有一位，必须要有一个点，后面必须是有两个数字，最后是一个单词的结束
            string replacement = "$$$&";
            string input = "Total cost: 103.64";
            Console.WriteLine(Regex.Replace(input, pattern, replacement));
        }
        /// <summary>
        /// 分割一个字符串
        /// </summary>
        private static void RegexSplit() 
        {
            string input = "1. Egg 2. Bread 3. Mike 4. Coffee";
            string pattern = @"\b\d{1,2}\.\s";
            //首先是有一个单词的开始，然后有一个数字，它可能是一位，也可能是两位，接下来必须要有个点，然后必须要有一个空格，然后是一个结尾。
            foreach (string item in Regex.Split(input,pattern))
            {
                if (!String.IsNullOrEmpty(item))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
