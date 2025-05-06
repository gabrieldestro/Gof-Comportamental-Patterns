using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediator.Colleage;

namespace Mediator.Mediator
{
    public class GroupMediator : IGroupMediator
    {
        private List<AbstractUser> userList = new List<AbstractUser>();

        public void RegisterUser(AbstractUser user)
        {
            userList.Add(user);
        }

        public void SendMessage(AbstractUser user, string message)
        {
            foreach (AbstractUser us in userList)
            {
                if (us != user)
                {
                    us.Receive(message);
                }
            }
        }
    }
}
