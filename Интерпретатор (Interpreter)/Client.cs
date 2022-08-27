using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Интерпретатор__Interpreter_
{
    class Client
    {
        void Main()
        {
            Context context = new Context();
            var expression = new NonterminalExpression();
            expression.Interpret(context);
        }
    }
}
