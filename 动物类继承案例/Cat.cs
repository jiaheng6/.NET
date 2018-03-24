using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 动物类继承案例
{
    class Cat:Animal
    {
        //如果父类时抽象类，那么子类在继承的时候，必须要把父类（抽象类）中所有的抽象成员重写
        //除非该子类是抽象类
        //重写
        public override void Shout() 
        {
            Console.WriteLine("喵喵叫");
        }
    }
}
