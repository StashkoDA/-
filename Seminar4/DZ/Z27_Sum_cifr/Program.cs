// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetNumber(string text) // функция запроса ввода числа
{
    Console.Write(text + ": ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int SumNumbers(int a) // ф-ция вычисления суммы цифр
{
    int sum = 0;
    while (a > 0)
        {
            sum += a % 10;
            a = a / 10;
        }
    return sum;
}

void Print(int a, int sum) // ф-ция вывода ответа
    {
        string answer = "Введено число: " + a + ", сумма цифр числа = " + sum;
        Console.WriteLine(answer);
    }

int a = GetNumber("a"); // исходное число
int sum = SumNumbers(a);
Print(a, sum);