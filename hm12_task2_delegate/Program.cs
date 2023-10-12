using hm12_task2_delegate;

int a = 4;
int b = 5;
int result = 0;

MathOps mathOps = new MathOps();

Func<int, int, int> func = mathOps.Sum;
func += mathOps.Dif;
func += mathOps.Mult;

foreach (Func<int, int, int> math in func.GetInvocationList())
{
    Console.WriteLine(result = math(a, b));
}