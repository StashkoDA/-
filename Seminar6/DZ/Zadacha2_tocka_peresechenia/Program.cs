/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

double Numb(string text) // ввод исходных данных
{
    Console.Write(text);
    double numb = Convert.ToDouble(Console.ReadLine());
    return numb;
}

double GetPointX(double k1, double b1, double k2, double b2) // поиск пересечения X
{
    double xx = (b2 - b1) / (k1 - k2);
    return xx;
}

double GetPointY(double k1, double b1, double x) // поиск пересечения Y
{
    double yy = k1 * x + b1;
    return yy;
}

void PrintPoint(double k1, double b1, double k2, double b2, double x, double y) //печать точки пересечения
{
    Console.Write("k1 = " + k1 + ", b1 = " + b1 + ", k2 = " + k2 + ", b2 = " + b2
     + " -> (" + Math.Round(x, 2) + "; " + Math.Round(y, 2) + ")");
}

double k1 = Numb("Введите значение k1: "); // ввод исходных данных
double b1 = Numb("Введите значение b1: ");
double k2 = Numb("Введите значение k2: ");
double b2 = Numb("Введите значение b2: ");

double x = GetPointX(k1, b1, k2, b2); // поиск пересечения X
double y = GetPointY(k1, b1, x); // поиск пересечения Н

PrintPoint(k1, b1, k2, b2, x, y); //печать точки пересечения
Console.WriteLine();