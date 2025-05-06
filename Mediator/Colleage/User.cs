using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediator.Mediator;

namespace Mediator.Colleage
{
    public class User : AbstractUser
    {
        public User(IGroupMediator mediator, string name) : base(mediator, name)
        {
        }

        public override void Receive(string message)
        {
            Console.WriteLine($"{_name}: recevied message: {message}");
        }

        public override void Send(string message)
        {
            Console.WriteLine($"{_name}: recevied sent: {message}");
            _mediator.SendMessage(this, message);
        }
    }
}
