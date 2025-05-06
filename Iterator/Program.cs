using Iterator;
using Iterator.Aggregate;
using Iterator.Iterator;

ConcreteCollection collection = new ConcreteCollection();

collection.AddClient(new Client("John", 1));
collection.AddClient(new Client("Mary", 2));
collection.AddClient(new Client("Gabriel", 3));

ConcreteIterator it = collection.CreateIterator();

Console.WriteLine("Iterating over collection: ");
for (Client cl = it.First(); !it.IsDone; cl = it.Next())
{
    Console.WriteLine($"ID : {cl.Id} & Name : {cl.Name}");
}