using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observer.Subject;

namespace Observer.Observer
{
    public class ConcreteObserver : IObserver
    {
        public string User { get; set; }

        public ConcreteObserver(string user, ISubject subject)
        {
            User = user;
            subject.RegisterObserver(this);
        }

        public void Update(string availability)
        {
            Console.WriteLine($"Observer {User} got notified: Availability changed to: {availability}");
        }
    }
}
