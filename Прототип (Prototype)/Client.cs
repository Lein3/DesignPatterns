using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Прототип__Prototype_
{
    internal class Client
    {
        void Operation()
        {
            Prototype prototype = new ConcretePrototype1(1);
            Prototype clone = prototype.Clone();
            prototype = new ConcretePrototype2(2);
            clone = prototype.Clone();
        }
    }
}
