#region

using System.Numerics;
using ConsoleApp1;

#endregion

BigInteger first = 0;
BigInteger second = 1;
byte num = 100;

for (int x = 0; x < num; x++)
{
    BigInteger third = first + second;
    first = second;
    second = third;
}

Console.WriteLine(first);

Console.WriteLine(Fibonacci.Recursive(num, 1, 0));

Console.WriteLine(Fibonacci.DemoExample(100));