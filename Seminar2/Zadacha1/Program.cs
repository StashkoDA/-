﻿// программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// например: для числа 78 наибольшая цифра 8, а для 33 цифры равны.
void CamperoDigits() //CamperoDigits - это произвольное имя функции (сравнить)
    {
    int x = new Random().Next(10,100);
    int x1 = x/10; //определяем первую цифру числа
    int x2 = x%10; //определяем вторую цифру числа
    Console.WriteLine($"Сгенерировано случайное число {x} ");
    if (x1>x2) Console.WriteLine("Первая цифра больше");
    else if (x1<x2) Console.WriteLine("Вторая цифра больше");
    else Console.WriteLine("Эти цифры равны"); //или "Это полиндром"
    }

CamperoDigits();
