using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Хранитель__Memento_
{
    class Memento
    {
        public string State { get; private set; }
        public Memento(string state)
        {
            this.State = state;
        }
    }
}
