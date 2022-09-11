// Задача 23 - Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27 // 5 -> 1, 8, 27, 64, 125

string KubTable(int num)
{
    string res = $"{num} -> ";
    if (num > 0)
        {
            for (int i = 1; i <= num; i++)
                {
                    res = res + $" {Math.Pow(i, 3)},"; // {Math.Pow(i, 3)} - это возведение в степень 3
                }
        }
    else if (num < 0)
        {
            for (int i = -1; i >= num; i--)
                {
                    res = res + $" {Math.Pow(i, 3)},"; // {Math.Pow(i, 3)} - это возведение в степень 3

                }
        }
    return res;
}
try
{
    Console.Write("Введите число = ");
    int num = Convert.ToInt32(Console.ReadLine());
    //int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    Console.WriteLine(KubTable(num));
}
catch
{
    Console.WriteLine("Надо было ввести целое число");
}