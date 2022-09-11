// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

string squareTable(int num)
{
    string result = $"{num} -> 1";

    for (int i = 2; i <= num; i++)
    {
        result = result + $", {Math.Pow(i, 2)}"; // {Math.Pow(i, 2)} - это возведение в степень квадрата

    }

    return result;
}

try
{
    System.Console.Write("Введите число = ");
    int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    System.Console.WriteLine(squareTable(num));


}
catch
{
    System.Console.WriteLine("Вводите целочисленное значение");
}