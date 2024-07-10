ulong first = 0;
ulong second = 1;
ulong third;
byte num = 100;

for (int x = 0; x < num; x++)
{
    third = first + second;
    first = second;
    second = third;
}

Console.WriteLine(first);
