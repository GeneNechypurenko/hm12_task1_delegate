using hm12_task2_delegate;

Random rand = new Random();

int a = 4;
int b = 5;

MathOps mathOps = new MathOps();

Func<int, int, int> sum = mathOps.Sum;
Func<int, int, int> dif = mathOps.Dif;
Func<int, int, int> mult = mathOps.Mult;

int sumResult = sum.Invoke(a, b);
int difResult = dif.Invoke(a, b);
int multResult = mult.Invoke(a, b);

Console.WriteLine($"Adding: {a} + {b} = {sumResult}");
Console.WriteLine($"Substracting: {a} - {b} = {difResult}");
Console.WriteLine($"Multiplying: {a} * {b} = {multResult}");