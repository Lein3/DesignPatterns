using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Строитель__Builder_
{
    internal class Client
    {
        void Main()
        {
            Builder builder = new ConcreteBuilder();
            Director director = new Director(builder);
            director.Construct();
            Product product = builder.GetResult();
        }
    }
}
