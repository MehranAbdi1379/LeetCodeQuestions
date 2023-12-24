// See https://aka.ms/new-console-template for more information

Console.WriteLine(MinOperations("01"));

int MinOperations(string s)
{
    var secondCounter = 0;
    var counter = 0;
    char previous = s[0];
    for (int i = 1; i < s.Length; i++)
    {
        if (s[i] == previous)
        {
            counter++;
            previous = previous == '0' ? '1' : '0';
        }
        else
            previous = s[i];
    }

    previous = s.Last();

    for (int i = s.Length - 2; i >= 0; i--)
    {
        if (s[i] == previous)
        {
            secondCounter++;
            previous = previous == '0' ? '1' : '0';
        }
        else
            previous = s[i];
    }
    return counter > secondCounter ? counter : secondCounter;
}