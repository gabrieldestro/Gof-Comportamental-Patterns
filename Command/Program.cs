using Command.Command;
using Command.Invoker;
using Command.Receiver;

Chef chef = new Chef();

// dish
Order order = new Order(chef, "Dish");
Waiter waiter = new Waiter(order);
waiter.Execute();

// dessert
order = new Order(chef, "Dessert");
waiter = new Waiter(order);
waiter.Execute();