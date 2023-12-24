// See https://aka.ms/new-console-template for more information

Console.WriteLine(TrailingZeroes(125));

int TrailingZeroes(int n)
{
    int result = 0;
    while (n > 0)
    {
        result += (n / 5);
        n = n / 5;
    }
    return result;
}