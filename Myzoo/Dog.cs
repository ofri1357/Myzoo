using System;
using System.Collections.Generic;
using System.Text;

namespace Myzoo
{
    public class Dog : Animal
    {
        public override string SayHello()
        {
            return $"Dog {Name} says: woof";
        }



    }
}
