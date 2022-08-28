using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Мост__Bridge_
{
    class Client
    {
        static void Main()
        {
            Abstraction abstraction;
            abstraction = new RefinedAbstraction(new ConcreteImplementorA());
            abstraction.Operation();
            abstraction.Implementor = new ConcreteImplementorB();
            abstraction.Operation();
        }
    }
}
