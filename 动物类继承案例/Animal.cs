using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 动物类继承案例
{
    //每个类都有一个默认的访问修饰符
    public abstract class  Animal
    {
        //字段 封装成属性
        //方法
        /// <summary>
        /// 虚方法 关键字virtural，虚方法必须有主体（必须有大括号）、
        /// 抽象方法 abstract 不能有主体（不能有大括号），而且必须在抽象类中。
        /// </summary>
        public abstract void Shout();
        //{
        //    Console.WriteLine();
        //}
    }
}
