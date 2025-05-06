using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter.Expressions
{
    public class Separator : IAbstractExpression
    {
        public void Interpret(Context context)
        {
            context._expression = context._expression.Replace(" ", "-");
        }
    }
}
