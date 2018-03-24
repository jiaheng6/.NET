using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 索引器
{
    class Program
    {
        static void Main(string[] args)
        {
            //索引器，通过索引的方式来访问这个元素中的某个元素
            //int[] nums = { 1,2,3,4,5,6};
            //Console.WriteLine(nums[2]);
            Person p = new Person();
            Console.WriteLine(p[2]);
            Console.ReadKey();
        }List<int>
    }
    public class Person 
    {
        public string[] names = { "name1","name2","name3","name4"};
         //可以仿照List中的定义方法来定义索引器public T this[int index] { get; set; }
        public string this[int index]
        {
            get 
            {
                string str = "";
                switch (index)
                {
                    case 0: str = names[0];
                        break;
                    case 1: str = names[1];
                        break;
                    case 2: str = names[2];
                        break;
                    case 3: str = names[3];
                        break;
                }
                return str;
            }
        }
    }
}
