// Возведение числа А в степень N

// Без рекурсии:
int PowerFor(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++)
    {
        result *= a;
    }
    return result;
}

// С рекурсией:
int PowerRec(int a, int n)
{
    if (n == 0) return 1;
    else return a * PowerRec(a, n - 1);
    // или: return n == 0 ? 1 : a * PowerRec(a, n - 1);
}

Console.WriteLine(PowerFor(2, 10));
Console.WriteLine(PowerRec(2, 10));
