Console.WriteLine("Введите число n, являющееся натуральным: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число m, являющееся натуральным: ");
int m = Convert.ToInt32(Console.ReadLine());

SumOfNaturalNumbers(n,m);

void SumOfNaturalNumbers (int a, int b)
{
int result = 0;
if (a <= 0 || b  <= 0) 
{
Console.WriteLine("Одно или оба введенных числа не являются натуральными числами");
}
else
{
if (a > b)
{
result = (a + b) * (a - b + 1) / 2;
Console.WriteLine($"{result}");
}
else
{
result = (a + b) * (b - a + 1) / 2;
Console.WriteLine($"{result}");
}
}
}
