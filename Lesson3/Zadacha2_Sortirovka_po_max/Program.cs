// Задача 2.1 - Отсортировать массив 6 8 3 2 1 4 5 7 1 1 от минимального до максимального значения

int [] arr = {6, 8, 3, 2, 1, 4, 5, 7, 1, 1};

void PrintArray(int[] array) // вывод массива на экран
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }


        int temporary = array[i];           // производим замену элементов далее
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
Console.Write("Сортировка от мин к макс значению: ");
SelectionSort(arr);
PrintArray(arr);
Console.WriteLine();


// Задача 2.2 - Отсортировать массив 6 8 3 2 1 4 5 7 1 1 от максимального до минимального значения
/*
int [] arr1 = {6, 8, 3, 2, 1, 4, 5, 7, 1, 1};

void PrintArray1(int[] array1) // вывод массива на экран
{
    int count1 = array1.Length;
    for (int i = 0; i < count1; i++)
    {
        Console.Write($"{array1[i]} ");
    }
    Console.WriteLine();
}
void SelectionSort1(int[] array1)
{
    for (int i = 0; i < array1.Length - 1; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < array1.Length; j++)
        {
            if(array1[j] > array1[maxPosition]) maxPosition = j;
        }


        int temporary1 = array1[i];           // производим замену элементов далее
        array1[i] = array1[maxPosition];
        array1[maxPosition] = temporary1;
    }
}

PrintArray1(arr1);
Console.Write("Сортировка от макс к мин значению: ");
SelectionSort1(arr1);
PrintArray1(arr1);
*/