using Observer.Observer;

namespace Observer.Subject
{
    public class ConcreteSubject : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        public string Product { get; set; }
        public decimal Price { get; set; }
        public string Availablity { get; set; }

        public ConcreteSubject(string product, decimal price, string availability)
        {
            Product = product;
            Price = price;
            Availablity = availability;
        }

        public void SetAvailability(string availability)
        {
            Availablity = availability;
            Notify();
        }

        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update(Availablity);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
    }
}
