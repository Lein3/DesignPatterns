using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фабричный_метод__Factory_Method_
{
    internal class ConcreteCreatorA : CreatorBase
    {
        public override ProductBase FactoryMethod()
        { 
            return new ConcreteProductA();
        }
    }
}
