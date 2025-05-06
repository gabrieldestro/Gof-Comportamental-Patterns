using Interpreter;
using Interpreter.Expressions;

List<IAbstractExpression> expressions = new List<IAbstractExpression>();
Context ctx = new Context(DateTime.Today);

Console.WriteLine($"Today: {ctx._date}");
Console.WriteLine("Select the expression: MM-DD-YYYY, YYYY-MM-DD or DD-MM-YYYY");

ctx._expression = Console.ReadLine().ToUpper();

string[] format = ctx._expression.Split("-");
foreach (var item in format)
{
    if (item == "DD") expressions.Add(new ExpressionDay());
    if (item == "MM") expressions.Add(new ExpressionMonth());
    if (item == "YYYY") expressions.Add(new ExpressionYear());
}

expressions.Add(new Separator());

foreach (var obj in expressions)
{
    obj.Interpret(ctx);
}

Console.WriteLine($"Formated date: {ctx._expression}");