using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字符串练习题一
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 接受用户输入的字符串，将其中的字符以与输入相反的顺序输出，“abc”-->“bca”
            
            #endregion

           #region 第一种方法，使用字符数组的Reverse()函数
            /*Console.WriteLine("请输入字符串：");
            string str = Console.ReadLine();
            char[] a = str.ToCharArray();
            Array.Reverse(a);//翻转数组顺序
            Console.WriteLine(a);
            string b = "";
            for (int i = 0; i < a.Length; i++)
            {
                b = b + a[i].ToString();
            }
            Console.WriteLine(b); */
           #endregion

            #region 第二种方法：自定义数组元素交换方法
            Console.WriteLine("请输入字符串：");
            string msg = Console.ReadLine();
            string msgs = ChangeString(msg);
            Console.WriteLine(msgs); 
            #endregion
        }


        #region 数组元素交换方法
        private static string ChangeString(string msg)
        {
            //把字符串转成字符数组
            char[] chs = msg.ToCharArray();
            char temp;
            for (int i = 0; i < chs.Length / 2; i++)//只需要转换数组长度的一半的次数
            {
                temp = chs[i];
                chs[i] = chs[chs.Length - 1 - i];
                chs[chs.Length - 1 - i] = temp;
            }
            return new string(chs);
        } 
        #endregion
    }
}
