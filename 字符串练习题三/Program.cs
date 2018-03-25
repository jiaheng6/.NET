using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字符串练习题三
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 2012年12月21日，从字符串中把年月日分别取出来，打印到控制台
            #endregion

            string datetime = "2012年12月21日";
            string dateStr = "";
            string[] strDate = datetime.Split(new char[]{'年','月','日'},StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < strDate.Length; i++)
            {
                //Console.WriteLine(strDate[i]);
                dateStr =dateStr+ strDate[i];
            }
            Console.WriteLine(dateStr);
            

        }
    }
}
