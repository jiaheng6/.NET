using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace 字符串练习题四
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 把.csv文件中的联系人姓名和电话显示出来，简单模拟csv文件，csv文件就是使用,分割数据的文本输出
            #endregion


            //第一步：读取文件
           
                //string str = System.IO.File.ReadAllText(@"E:\C#补充学习\CSharpBasicLearn\字符串练习题四\data.csv");
                //Console.WriteLine(str);
                string[] lines = System.IO.File.ReadAllLines(@"E:\C#补充学习\CSharpBasicLearn\字符串练习题四\data.csv",Encoding.Default);
                
           
           
            //第二步：格式化每行数据
            for (int i = 0; i <lines.Length ; i++)
            {
                string[] txts = lines[i].Replace(",", "").Split(new char[]{'"'} ,StringSplitOptions.RemoveEmptyEntries);
                
                //显示效果
                Console.WriteLine("姓名是：{0}",txts[0]+txts[1]);
                Console.WriteLine("电话号是：{0}",txts[2]);
            }

            


        }
    }
}
