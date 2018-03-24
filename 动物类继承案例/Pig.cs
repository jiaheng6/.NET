using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 动物类继承案例
{
    class Pig:Animal
    {
        public override void Shout()
        {
            Console.WriteLine("哼哼叫");
        }
    }
}
