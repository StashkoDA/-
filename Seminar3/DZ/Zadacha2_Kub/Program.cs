// Задача 21 - Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Rasst(int xA, int yA, int zA, int xB, int yB, int zB) // ввод ф-ции, определяющей координаты точки
    {
        double res; // ввод имени ф-ции для вывода результата 
        int a = xA - xB;
        int b = yA - yB;
        int c = zA - zB;
        res = Math.Sqrt(a*a + b*b + c*c);
        return res;
    }
try
    {
        Console.Write ("Введите координату хA: ");
        int xA = Convert.ToInt32 (Console.ReadLine());
        Console.Write ("Введите координату yA: ");
        int yA = Convert.ToInt32 (Console.ReadLine());
        Console.Write ("Введите координату zA: ");
        int zA = Convert.ToInt32 (Console.ReadLine());
        Console.Write ("Введите координату хB: ");
        int xB = Convert.ToInt32 (Console.ReadLine());
        Console.Write ("Введите координату yB: ");
        int yB = Convert.ToInt32 (Console.ReadLine());
        Console.Write ("Введите координату zB: ");
        int zB = Convert.ToInt32 (Console.ReadLine());

        double rez = Rasst(xA, yA, zA, xB, yB, zB);
        Console.WriteLine($"Расстояние между точками равно {rez}");
    }
catch
    {
        Console.WriteLine("Надо было вводить целые числа координат");
    }