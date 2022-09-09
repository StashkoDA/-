// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и
// на выходе показывает вторую цифру этого числа.
// 456 -> 5; 782 -> 8; 918 -> 1

try
{
    void Bum(int numb)
        {
            if ( numb > 99 & numb <1000 )
                {
                    numb = (numb/10)%10;
                    Console.WriteLine("Это вторая цифра числа "+numb);
                }
            else Console.WriteLine("Надо было ввести трёхзначное число");
        }
    Console.Write("Введите трёхзначное число: ");
    int numb = Convert.ToInt32 (Console.ReadLine());
    Bum(numb);
    Console.WriteLine();
}
catch
    {
        Console.WriteLine("Надо было ввести трёхзначное число");
    }