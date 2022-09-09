// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5; 78 -> третьей цифры нет; 32679 -> 6

try
{
    void Drei(int numb)
        {
            if ( numb > 99 || numb < -99)
                {
                    while (numb > 999)
                    {
                        numb = numb / 10;
                    }
                    numb = numb % 10;
                    while (numb < -999)
                    {
                        numb = numb / 10;
                    }
                    numb = numb % 10;
                    Console.WriteLine("Это третья цифра числа "+numb);
                }
            else Console.WriteLine("третьей цифры нет");
        }
    Console.Write("Введите целое число: ");
    int numb = Convert.ToInt32 (Console.ReadLine());
    Drei(numb);
    Console.WriteLine();
}
catch
    {
        Console.WriteLine("Надо было ввести целое число");
    }