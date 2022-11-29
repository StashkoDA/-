/*
Собрать строчку с числами от А до Б
*/

// Без рекурсии:
/*
string NumbersFor(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}

// С рекурсией:
string NumbersRec(int a, int b)
{
    if (a <= b) return $"{a} " + NumbersRec(a +1, b);
    else return String.Empty;
}

Console.WriteLine(NumbersFor(1, 10));
Console.WriteLine(NumbersRec(1, 10));
*/
// От большего к меньшему:
// Без рекурсии:
string NumbersFor(int a, int b)
{
    string result = String.Empty;
    for (int i = b; i >= a; i--)
    {
        result += $"{i} ";
    }
    return result;
}

// С рекурсией:
string NumbersRec(int a, int b)
{
    if (a <= b) return NumbersRec(a +1, b) + $"{a} ";
    else return String.Empty;
}

Console.WriteLine(NumbersFor(1, 10));
Console.WriteLine(NumbersRec(1, 10));