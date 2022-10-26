// 14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет

void numbers(int num)
{
if (num % 7 == 0)
{
    if (num % 23 == 0) Console.WriteLine("Число кратно 7 и 23");
    else Console.WriteLine("Число не кратно 23");
}
else if (num % 23 == 0)
{
    if (num % 7 == 0) Console.WriteLine("Число кратно 7 и 23");
    else Console.WriteLine("Число не кратно 23");
}
else Console.WriteLine($"Число не кратно 7 и 23");
}

Console.Write("Введите целое число: ");
int num = int.Parse(Console.ReadLine()!); // - здесь равноценно вводу Convert.ToInt32 (Console.ReadLine());

numbers(num);
Console.WriteLine();

// или короче:void Num (int number)
// void Num (int number)
// {
//      if (number % 7 == 0 & number % 23 == 0) или if (number % 7 + number % 23 == 0)
//          {
//          Console.WriteLine($"Число {number} кратно 7 и 23");
//          }
//      else
//          {
//          Console.WriteLine($"Число {number} НЕ кратно 7 и 23");
//          }
// }

// Num(161);
