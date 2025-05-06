
using Mediator.Colleage;
using Mediator.Mediator;

GroupMediator mediator = new GroupMediator();

User john = new User(mediator, "John");
User mary = new User(mediator, "Mary");
User gabriel = new User(mediator, "Gabriel");

mediator.RegisterUser(john);
mediator.RegisterUser(mary);
mediator.RegisterUser(gabriel);

john.Send("Old message broadcasted!");
mary.Send("New message broadcasted!");
gabriel.Send("Newer message broadcasted!");