using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字符串练习题二
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 接受用户输入的一句英文，将其中的单词以反序输出，"i love you"-->"i evol uoy"
            #endregion
            Console.WriteLine("请输入字符串：");
            string msg = Console.ReadLine();
            string[] msgs = msg.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries/*避免出现截取空项*/);//通过空格将字符串中单词分割开，转为字符串数组
            string a = "";
            for (int i = 0; i < msgs.Length; i++)
            {
                a += ChangeString(msgs[i])+" ";//将每个单词倒序，加上空格重新添加到字符串中
            }
            Console.WriteLine(a);

        }
        /// <summary>
        /// 字符串倒序转换函数
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
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
    }
}
