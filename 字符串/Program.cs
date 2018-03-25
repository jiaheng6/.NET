using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 冗余代码
            ////字符串实际上就相当于字符数组
            //string name = "Hello World";
            ////name[2] = 'b';
            //Console.WriteLine(name[2]);//l

            //string name1 = "张三";
            //string name2 = "张三";//字符串将相同的值存储在暂存池中 
            #endregion

            #region ToLower()和ToUpper()字符串的大小写转换
            //string msg = "HOW ARE YOU";
            //string a = msg.ToLower();
            //string b = a.ToUpper();
            //Console.WriteLine(a);//how are you 
            //Console.WriteLine(b);//HOW ARE YOU 
            #endregion

            #region Equals()字符串的比较
            /*********************************/
            //string msg1 = "HOWARE YOU";
            //if (string.Equals(msg,msg1))
            //{
            //    Console.WriteLine("相同");
            //}
            //else
            //{
            //    Console.WriteLine("不相同");
            //} 
            #endregion

            #region boject.ReferenceEquals()对象的比较
            /************************************/

            //Person p1 = new Person();
            //Person p2 = new Person();
            //p1.Name = "小明";
            //p2.Name = "小明";
            //if (object.ReferenceEquals(p1,p2))
            //{
            //    Console.WriteLine("相同");
            //}
            //else
            //{
            //    Console.WriteLine("不相同");//虽然名字name相同，但是p1实例化时新开辟一个空间，p2用new实例化时也开辟一个空间，两个是不同的空间
            //} 
            #endregion

            #region IndexOf()和LastIndexOf()字符串的查找
            /*********************************************/
            //string msg = "床前明月光";
            //int a = msg.IndexOf("明");//查找一个字符或者字符串，找到了返回该字符串的索引，找不到返回-1
            //int b = msg.IndexOf("大");
            //Console.WriteLine(a);//返回“明”在字符串中的索引
            //Console.WriteLine(b);
            /*---------------------------------------------*/
            //string msg = "床前明月光";
            //int a = msg.LastIndexOf("明月");//从头查找，查找字符串最后一次出现的索引位置
            //Console.WriteLine(a); 
            #endregion

            #region Substring()字符串的截取
            /*---------------------------------------------*/
            //string msg = "HelloWorld";
            //string msg1 = msg.Substring(3);//从指定的索引位置开始截取字符串，一直到最后
            //string msg2 = msg.Substring(2, 3);//从指定位置开始截取指定长度的字符串
            //Console.WriteLine(msg1);//loworld
            //Console.WriteLine(msg2);//llo
            /*--------------------------------------*/
            
            #endregion

            #region Split()字符串的分割
            //string name = "小明，小红，大明，大红，大黑";
            //string[] msgs = name.Split(new char[] { '，' }, StringSplitOptions.RemoveEmptyEntries/*去除空项*/);
            //for (int i = 0; i < msgs.Length; i++)
            //{
            //    Console.WriteLine(msgs[i]);
            //} 
            #endregion

            #region string.join()字符串的连接
            //string[] names = { "小明", "小红", "小张", "大红", "大黑" };
            //string a = string.Join("&",names);
            //Console.WriteLine(a); 
            #endregion

            #region 按照指定格式返回字符串（格式化）
            //string a = string.Format("大家好，我是{0}，我来自{1}","小明","中国");
            //Console.WriteLine(a); 
            #endregion

            #region 字符串替换
            string str1 = "拒绝黄赌毒";
            if (str1.Contains("黄"))
            {
                str1 = str1.Replace("黄", "*");
                if (str1.Contains("毒"))
                {
                    str1 = str1.Replace("毒", "*");
                    if (str1.Contains("赌"))
                    {
                        str1 = str1.Replace("赌", "*");
                    }

                }
            } 
            #endregion
            
            
            Console.WriteLine(str1);


        }
        
    }
    class Person
    {
        public string Name { get; set; }
    }
}
