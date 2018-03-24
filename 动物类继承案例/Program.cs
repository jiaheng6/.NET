using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 动物类继承案例
{
    class Program
    {
        static void Main(string[] args)
        {
            Pig pig = new Pig();
            Dog dog = new Dog();
            Cat cat = new Cat();
            dog.Shout();
            cat.Shout();
            pig.Shout();
            
        }
    }
}
