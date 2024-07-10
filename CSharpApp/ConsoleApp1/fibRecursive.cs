#region

using System.Numerics;

#endregion

namespace ConsoleApp1;

internal class Fibonacci
{
    private static readonly BigInteger[] cache = new BigInteger[101];
    private readonly string _firstName;
    private readonly string _lastName;
    public Func<string> FullName => () => $"{_firstName} {_lastName}";

    public Fibonacci(string firstName, string lastName)
    {
        _firstName = firstName;
        _lastName = lastName;
    }

    public static BigInteger Recursive(int counter, BigInteger second, BigInteger first)
    {
        return counter == 0 ? first : Recursive(--counter, first + second, second);
    }

    public static BigInteger DemoExample(uint x)
    {
        if (x <= 1)
            return x;

        if (cache[x] != 0) return cache[x];

        BigInteger temp = DemoExample(x - 1) + DemoExample(x - 2);

        cache[x] = temp;

        return temp;
    }
}