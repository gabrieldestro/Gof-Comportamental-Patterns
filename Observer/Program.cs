using Observer.Observer;
using Observer.Subject;

ConcreteSubject phone = new ConcreteSubject("Phone", 1000, "OUT OF STOCK");

ConcreteObserver john = new ConcreteObserver("Jonh", phone);
ConcreteObserver mary = new ConcreteObserver("Mary", phone);
ConcreteObserver gabriel = new ConcreteObserver("Gabriel", phone);

phone.SetAvailability("AVAILABLE");