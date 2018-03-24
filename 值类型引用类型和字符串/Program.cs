using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 值类型引用类型和字符串
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
            

    //        int num = 1000;
    //        Test(num);
    //        Console.WriteLine(num); //结果是1000
    //    }
    //    public static void Test(int num) 
    //    {
    //        num = 100;
    //        //Console.WriteLine(num);//结果是100
    //    }
    //}
    class Program
    {
        static void Main(string[] args)
        {


            int num = 1000;
            Test(ref num);
            Console.WriteLine(num);//1000
        }
        public static void Test(ref int num)
        {
            num = 100;
            Console.WriteLine("test{0}",num);//100
        }
    }
}
