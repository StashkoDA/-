// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double GetNumber(string text) // функция запроса ввода чисел
{
    Console.Write(text + ": ");
    double number = Convert.ToDouble(Console.ReadLine());
    return number;
}

double GetDegree(double a, double b) // ф-ция возведения числа А в степень В
{
    double degree = Math.Pow(a, b); // возведение в степень
    return degree;
}

void Print(double a, double b, double degree) // ф-ция вывода текста ответа
{
    
    string answer = "Введено число " + a + ", введено число " + b + ", число А в степени В = " + degree;
  
Console.WriteLine(answer);
}

double a = GetNumber("a"); // исходное число
double b = GetNumber("b"); // значение степени
double degree = GetDegree(a, b);
Print(a, b, degree);

