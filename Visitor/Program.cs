using Visitor;

List<Car> cars = new List<Car>();
cars.Add(new Car() { Name = "A1", Price = 200M, Model = "Mercedez" });
cars.Add(new Car() { Name = "458", Price = 500M, Model = "Ferrari" });
cars.Add(new Car() { Name = "718 GTS", Price = 400M, Model = "Porsche" });

List<IStore> stores = new List<IStore>();

Console.WriteLine("Normal car prices:");
foreach (var car in cars)
{
    Console.WriteLine($"{car.Name} | {car.Model} - {car.Price}");
    stores.Add(car);
}

Console.WriteLine("\nDiscounted car prices:");
PriceVisitor visitor = new PriceVisitor();
foreach (var element in stores)
{
    element.Visit(visitor);
}