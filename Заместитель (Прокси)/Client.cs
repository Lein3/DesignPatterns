using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Заместитель__Прокси_
{
    class Client
    {
        void Main()
        {
            Subject subject = new Proxy();
            subject.Request();
        }
    }
}
