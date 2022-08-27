using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Посетитель__Visitor_
{
    class Client
    {
        void Main()
        {
            var structure = new ObjectStructure();
            structure.Add(new ElementA());
            structure.Add(new ElementB());
            structure.Accept(new ConcreteVisitor1());
            structure.Accept(new ConcreteVisitor2());
        }
    }
}
