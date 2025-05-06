using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command.Receiver;

namespace Command.Command
{
    public class Order: Command
    {
        public Chef _chef { get; set; }
        public string _action { get; set; }

        public Order(Chef chef, string action)
        {
            _chef = chef;
            _action = action;
        }

        public override void Execute()
        {
            if (_action == "Dish")
                _chef.PrepareDish();
            else
                _chef.PrepareDessert();
        }
    }
}
