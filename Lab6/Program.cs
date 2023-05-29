using Lab6;

AbstractExpression expression = new SubtractExpression(
            new AddExpression(new NumberExpression(10), new NumberExpression(5)),
            new SubtractExpression(new NumberExpression(1), new NumberExpression(6))
        );

int result = expression.Interpret();
Console.WriteLine("Result: " + result);