using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Receiver
{
    public class Chef
    {
        // Receiver
        public void PrepareDish()
        {
            Console.WriteLine("The chef is preparing the dish.");
        }

        public void PrepareDessert()
        {
            Console.WriteLine("The chef is preparing the dessert.");
        }
    }
}
