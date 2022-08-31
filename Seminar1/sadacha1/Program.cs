// See https://aka.ms/new-console-template for more information
Console.Write("Введите целое число ");
int x = Convert.ToInt32 (Console.ReadLine());
int y = x*x;
Console.WriteLine("Квадрат этого числа равен "+y);
if (x>0)
{
    Console.WriteLine("Число положительное");
}
else if (x<0) Console.WriteLine("Число отрицательное");
else Console.WriteLine("Вы ввели ноль");
