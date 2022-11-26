// Сколько путей получения из числа 2 число 11, используя команды +1 и *2?

/*
Рассуждени:
(i) - переходы:   из 2 в 3 в 4 в 5 в 6 в 7 в 8 в 9 в 10 в 11.
f(i) - кол-во путей: 1   1   2   2   3   3   5   5    7    7

4 = х + 1 \
            в четвёрку два пути
4 = х * 2 / 

        | 0, i < 2
        / 1, если i = 2
f(i) = { f(i/2) + f(i-1) если i - чётное
        \f(i-1),  если i - не чётное
*/

/*
// Решение для малых значений:
int f(int s, int e)
{
    if (e == s) return 1;
    else if (e % 2 == 0) return f(s, e / 2) + f(s, e - 1);
    else return f(s, e - 1);
}
Console.WriteLine($"f(2, 11): {f(2, 11)}");
*/

// Решение для больших значений через массив:
/*
long[] cache = new long[2023];
long f(long s, long e)
{
    if (e <= s) return 1;
    if (e < s) return 0;

    else if (e % 2 == 0)
    {
        long d = 0;
        if (cache[e / 2] != 0) d = cache[e / 2];
        else
        {
            d = f(s, e / 2);
            cache[e / 2] = d;
        }
        long q = 0;
        if (cache[e - 1] != 0) q = cache[e - 1];
        else
        {
            q = f(s, e - 1);
            cache[e - 1] = q;
        }
        return d + q;
    }
    else
    {
        long q = 0;
        if (cache[e - 1] != 0) q = cache[e - 1];
        else
        {
            q = f(s, e - 1);
            cache[e - 1] = q;
        }
        return q;
    }
}
Console.WriteLine($"f(23, 2022): {f(23, 2022)}");
*/

// Решение для больших значений через массив - упрощено:

long f(long s, long e)
{
    if (e < s) return 0;
    if (e == s) return 1;
    
    else if (e % 3 == 0) return f(s, e / 3) + f(s, e - 1);
    else return f(s, e - 1);
}
Console.WriteLine($"f(23, 2022): {f(23, 2022)}");