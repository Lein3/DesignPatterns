﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Шаблонный_метод__Template_Method_
{
    abstract class AbstractClass
    {
        public void TemplateMethod()
        {
            Operation1();
            Operation2();
        }
        public abstract void Operation1();
        public abstract void Operation2();
    }
}
