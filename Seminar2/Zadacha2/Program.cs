﻿// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

void Del() //Del - это произвольное имя функции (Удаление)
    {
    int x = new Random().Next(100,1000);
    int x1 = x/100; //определяем первую цифру числа
    int x2 = x%10; //определяем третью цифру числа
    int x3 = x1*10 + x2;
    Console.WriteLine($"Сгенерировано случайное число {x} ");
    Console.WriteLine("Удалена вторая цифра "+x3);
    }

Del();

// или:

//   void NewTask ()
//   {
//   int num = new Random().Next (100, 1000);
//
//    int res = num/100;
//    int res1 = num%10;
//
//    Console.WriteLine(num);
//    Console.WriteLine($"{res}{res1}");
//    }
//
//    NewTask ();