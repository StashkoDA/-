// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

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