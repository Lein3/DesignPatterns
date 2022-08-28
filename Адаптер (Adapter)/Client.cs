using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Адаптер__Adapter_
{
    class Client
    {
        public void Request(Target target)
        {
            target.Request();
        }
    }
}
