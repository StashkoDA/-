/*
Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int GetNumb(string text) // функция запроса ввода числа
{
    Console.Write(text);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int A(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if ((m > 0) && (n == 0))
    {
        return A(m - 1, 1);
    }
    else
    {
        return A(m - 1, A(m, n - 1));
    }
}

void PrintAkkerman(int m, int n, int res)
{
    Console.WriteLine("m = " + m + ", n = " + n + " -> A(m,n) = " + res);
}

int m = GetNumb("Введите значение параметра m: ");
int n = GetNumb("Введите значение параметра n: ");
int result = A(2, 3);
PrintAkkerman(m, n, result);