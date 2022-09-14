// Задача 30: Напишите программу, которая заполняет и выводит массив из N элементов,
// N - задается с клавиатуры, заполненный целыми случайными числами от 1 до 99.

int RndMassive(int N)
    {
        int[] array = new int[N];
        for (int i = 0; i < N; i++)
            {
                array[i] = new Random().Next(100);
            }
        return array;
    }
/*int[] maxIndex(int[] array)
    {
        int[] arrayMax = new int[2];
        int max = 0;
        int IndexMax = 0;
        for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                    {
                        max = array[i];
                        IndexMax = i;
                    }
            }
        arrayMax[0] = IndexMax;
        arrayMax[1] = max;
        return arrayMax;
    }*/

try
    {
        Sistem.Console.Write("Введите размер массива = ");
        int a = Convert.ToInt32(Console.Readline());
        int[] RndArray = RndMassive(a);
        /*Sistem.Console.WriteLine(String.Join(",", RndArray));
        Sistem.Console.WriteLine(String.Join(",", maxIndex(RndArray)));*/
    }
catch
    {
        Sistem.Console.WriteLine("Введено не число или число больше чем может вместить int");
    }
    // максимальный элемент и его индекс 