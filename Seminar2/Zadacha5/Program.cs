// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да

void numbers(int num1, int num2)
{
    if (num1 * num1 == num2) Console.WriteLine("Второе число это квадрат первого");
    if (num2 * num2 == num1) Console.WriteLine("Первое число это квадрат второго");
    else Console.WriteLine("Нет квадрата числа");
}

Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine()!); // - здесь равноценно вводу Convert.ToInt32 (Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine()!);

numbers(num1, num2);
Console.WriteLine();
