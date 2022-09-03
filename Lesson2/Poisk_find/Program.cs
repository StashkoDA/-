// В одномерном массиве array  из n  элементов найти эл-т массива, равный find (поиск индекса элемента).

int[] array = {15, 21, 39, 12, 23, 33, 123, 333, 23};
int n = array.Length; //задали длину массива.
int find = 23;
int index = 0;
while (index < n)
{
    if (array [index] == find)
    {
        Console.WriteLine(index);
        break; //прервать операцию при наждении первого эл-та, когда имеются одинаковые (23).
    }
    //index = index +1;
    index++;
}

