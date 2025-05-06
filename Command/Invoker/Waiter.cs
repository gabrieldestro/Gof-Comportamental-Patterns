using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command.Command;

namespace Command.Invoker
{
    public class Waiter
    {
        public Order _order { get; set; }
        public Waiter(Order order)
        {
            _order = order;
        }

        public void Execute()
        {
            _order.Execute();
        }
    }
}
