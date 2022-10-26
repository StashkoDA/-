// заполнение и вывод массива на экран.

void FillArray(int[] collection) //ф-ция ввода данных массива без вывода значений.
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10); // заполняем массив случайными числами от 1 до 10
        index++;
    }
}

void PrintArray(int[] col) //печать массива.
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collektion, int find) //возвращение индекса эл-та find из массива
{
    int count = collektion.Length;
    int index = 0;
    int position = -1; //задали -1, чтобы если введут число, не входящее в массив от 1 до 10, выдаст искомый индекс( позицию эл-та) как -1, что означает - эл-та нет в массиве.
    while (index < count)
    {
        if(collektion[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}
int[] array = new int[10]; //задание массива из 10 эл-тов.

FillArray(array); // вызываем функцию для заполнения массива
array[4] = 4;
array[6] = 4;
PrintArray(array); // вызываем функцию для вывода на экран полученного массива
Console.WriteLine();

int pos = IndexOf(array, 4); // поиск индексов элементов массива, элементы к-рых равны 4
Console.WriteLine(pos); // вывод искомого индекса элемента=4