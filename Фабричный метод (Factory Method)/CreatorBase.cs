using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фабричный_метод__Factory_Method_
{
    internal abstract class CreatorBase
    {
        public abstract ProductBase FactoryMethod();
    }
}
