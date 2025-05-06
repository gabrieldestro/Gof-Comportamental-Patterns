using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter.Expressions
{
    public interface IAbstractExpression
    {
        void Interpret(Context context);
    }
}
