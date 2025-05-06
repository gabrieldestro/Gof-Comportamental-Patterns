using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public class Context
    {
        public string _expression { get; set; }
        public DateTime _date { get; set; }

        public Context(DateTime date)
        {
            _date = date;
        }
    }
}
