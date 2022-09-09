// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
// 6 -> да; 7 -> да; 1 -> нет

try
{
    void Day(int numb)
    {
        if (numb > 0 & numb < 8)
        {
            if (numb == 6) Console.WriteLine("Это выходной");
            else if (numb == 7) Console.WriteLine("Это выходной");
            else Console.WriteLine("Это не выходной");
        }
        else Console.WriteLine("Введите целое число от 1 до 7");
    }
    Console.WriteLine("Введите целое число от 1 до 7");
    int numb = Convert.ToInt32 (Console.ReadLine());
    Day(numb);
    Console.WriteLine();
}
catch
{
Console.WriteLine("Введите целое число от 1 до 7");
}