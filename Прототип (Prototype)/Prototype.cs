using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Прототип__Prototype_
{
    internal abstract class Prototype
    {
        public int Id { get; private set; }
        public Prototype(int id)
        {
            this.Id = id;
        }
        public abstract Prototype Clone();
    }
}
