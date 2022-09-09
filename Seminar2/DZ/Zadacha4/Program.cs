// Задача 11 HARD - необязательная: Напишите программу,
// которая принимает на вход целое число любой разрядности число
// и удаляет вторую цифру слева направо этого числа.

try
{
    void Zwei(int numb)
        {
            if ( numb > 9 || numb < -9)
                {
                    int i = numb;
                    while (numb > 99)
                        {
                            i = numb % 10;
                            Console.Write(i+"");
                            numb = numb / 10;
                        }
                    i = numb / 10;
                    Console.Write(i+"");
                    numb = Console.Write(i+"");
                    
                    while (numb > 0)
                        {
                            i = numb % 10;
                            Console.Write(i+"");
                            numb = numb / 10;
                        }

                }
            else Console.WriteLine("Введите число не менее двуxзначного");
        }
    Console.Write("Введите целое число не менее двуxзначного: ");
    int numb = Convert.ToInt32 (Console.ReadLine());
    Zwei(numb);
    Console.WriteLine();
}
catch
    {
        Console.WriteLine("Надо было ввести целое число не менее двуxзначного");
    }



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