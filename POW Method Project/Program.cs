// See https://aka.ms/new-console-template for more information

Console.WriteLine(MyPow(1.0000000000001
    , -21474648));

double MyPow(double x, int n)
{
    double result = 1;
    long longN = n;
    if (n == 0)
    {
        return 1;
    }

    switch (x)
    {
        case 0:
            return 0;
        case 1:
        case -1 when n % 2 == 0:
            return 1;
        case -1:
            return -1;
    }

    if (n > 0)
    {
        for (var i = 0; i < longN; i++)
        {
            result *= x;
            if (result == 0)
            {
                return 0;
            }
        }
    }
    else
    {
        x = 1 / x;
        for (var i = 0; i < -longN; i++)
        {
            result *= x;
            if (result == 0)
            {
                return 0;
            }
        }
    }
    return result;
}