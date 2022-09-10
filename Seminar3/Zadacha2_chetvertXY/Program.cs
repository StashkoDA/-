// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).

string CheckChetvert(int Chetvert) // ввод ф-ции, определяющей четверть плоскости
    {
        string res;// ввод имени ф-ции для вывода координат
        if (Chetvert==1) res = "Координаты точки в области {+x,+y}";
        else if (Chetvert==4) res = "Координаты точки в области {+x,-y}";
        else if (Chetvert==3) res = "Координаты точки в области {-x,-y}";
        else if (Chetvert==2) res = "Координаты точки в области {x,+y}";
        else res = "Задано не корректное значение четверти";
        return res;
    }
try
    {
        Console.Write ("Введите № четверти от 1 до 4: ");
        int Chetvert = Convert.ToInt32 (Console.ReadLine());
        string rez = CheckChetvert(Chetvert);
        Console.WriteLine(rez);
    }
catch
    {
        Console.WriteLine("Надо было вводить целые числа координат");
    }

// или
string whatCoord(int num)
{
switch(num)
{
case 1:
{
return "x > 0, y > 0";
}
case 2:
{
return "x < 0, y > 0";
}
case 3:
{
return "x < 0, y < 0";
}
case 4:
{
return "x > 0, y < 0";
}
default:
{
return "Нет такой четверти!";
}
}
}
try {
Console.WriteLine("Введите номер четверти ");
int quarter = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(whatCoord(quarter));
}
catch
{
Console.WriteLine("Нужно ввести целое число");
}