// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21
/*
double Rasst(int xA, int yA, int xB, int yB) // ввод ф-ции, определяющей координаты точки
    {
        double res; // ввод имени ф-ции для вывода результата 
        int a = xA - xB;
        int b = yA - yB;
        res = Math.Sqrt(a*a + b*b);
        return res;
    }
try
    {
        Console.Write ("Введите координату хA: ");
        int xA = Convert.ToInt32 (Console.ReadLine());
        Console.Write ("Введите координату yA: ");
        int yA = Convert.ToInt32 (Console.ReadLine());
        Console.Write ("Введите координату хB: ");
        int xB = Convert.ToInt32 (Console.ReadLine());
        Console.Write ("Введите координату yB: ");
        int yB = Convert.ToInt32 (Console.ReadLine());

        double rez = Rasst(xA, yA, xB, yB);
        Console.WriteLine($"Расстояние между точками равно {rez}");
    }
catch
    {
        Console.WriteLine("Надо было вводить целые числа координат");
    }
*/
    /// или



double GetValue(string text) // функция запроса ввода координат
{
    Console.Write(text + ": ");
    double value = Convert.ToDouble(Console.ReadLine());
    return value;
}

void Print(double ax, double ay, double bx, double by, double result) // ф-ция вывода текста ответа
{
    // |A(1, 2); B(4, 5)| = 6 - вид изображения координат точек и рассояния м/д ними
    string output = "|A(" + ax + ", " + ay + "); B(" +
                            bx + ", " + by + ")| = " +
                    // result;
                    Math.Round(result, 2); // вывод результата с двумя знаками после запятой
Console.WriteLine(output);
}

double GetDistance(double ax, double ay, double bx, double by) // ф-ция определения расстояния м/д точками
{
    double x = (ax - bx) * (ax - bx); // возведение в квадрат
    double y = Math.Pow(ay - by, 2); // возведение в квадрат (в степень 2)
    double result = Math.Sqrt(y + x);
    return result;
}
double ax = GetValue("ax"); // запрос ввода координат
double ay = GetValue("ay");
double bx = GetValue("bx");
double by = GetValue("by");

double dis = GetDistance(ax, ay, bx, by); // запрос ф-ции вычисления расстояния
Print(ax, ay, bx, by, dis); // вывод на экран координат точек и расстояния м/д ними