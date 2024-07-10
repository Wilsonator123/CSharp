namespace ConsoleApp1;

internal class Fibonacci
{
    public static ulong Recursive(ulong first, ulong second, byte counter)
    {
        if (counter == 100) return first;

        first = Recursive(second, first + second, ++counter);

        return first;
    }
}