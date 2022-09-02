// See https://aka.ms/new-console-template for more information
Console.Write("Введите целое число от 1 до 7 = ");
try
    {
    int x = Convert.ToInt32 (Console.ReadLine());
    if (x==1) Console.WriteLine("Это понедельник");
    else if (x==2) Console.WriteLine("Это вторник");
    else if (x==3) Console.WriteLine("Это среда");
    else if (x==4) Console.WriteLine("Это четверг");
    else if (x==5) Console.WriteLine("Это пятница");
    else if (x==6) Console.WriteLine("Это суббота");
    else if (x==7) Console.WriteLine("Это воскресение");
    else if (x<1) Console.WriteLine("Вы ввели число меньше 1");
    else if (x>7) Console.WriteLine("Вы ввели число больше 7");
    }
catch
{
    Console.WriteLine("Надо было ввести целое число");
}