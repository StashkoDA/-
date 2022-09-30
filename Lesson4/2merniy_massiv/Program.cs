// 

/*
string[,] table = new string[2, 5]; // двумерный массив
// визуальный вид массива:
// String.Empty - инициализация пустой строки, если массив ничем не заполнен
// table[0, 0]   table[0, 1]    table[0, 2] ... table[0, 4]
// table[1, 0]   table[1, 1]    table[1, 2]     table[1, 4]

table[1, 2] = "слово"; // присвоили значение элементу массива
for (int rows = 0; rows < 2; rows++) // обращение к строкам массива для вывода
{
    for (int colums = 0; colums < 5; colums++) // // обращение к столбцам массива для вывода
    {
        Console.WriteLine($"{table[rows, colums]}-"); // печать массива
    }
}
*/
// Пример с матрицей:
/*
int[,] matrix = new int[3, 4];
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
Console.WriteLine();
}
*/
// ИЛИ
/*
int[,] matrix = new int[3, 4];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
Console.WriteLine();
}
*/

// Применем функцию для вывода матрицы:
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10); // заполняем массив случайными числами из полуинтервала (1, 10]
        }
    }
}

int[,] matrix = new int[3, 4];
PrintArray(matrix);
Console.WriteLine(); // введено для создания пустой строки между матрицами
FillArray(matrix);
PrintArray(matrix);

/* ЗАКРАСКА ОБЛАСТИ КАРТИНКИ, ПРЕДСТАВЛЕННой ВВИДЕ ДВУМЕРНОГО МАССИВА С НУЛЯМИ И ЕДИНИЦАМИ, СОЗДАЮЩИМ КАРТИНКУ.
Принимаем, что 0 - закрашенный пиксель, а 1 - не закрашенный пиксель.
pic - это говорится о пикселе.

int[,] pic = new int[,] - ниже должны быть приведены фиксированные данные массива, поэтому не указано кол-во строк и столбцов.
{
    {0, 0, 0, 0, ... 1, 0, ...0},
    {0, .......................},
    ...
}
void PrintImage(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            //Console.Write($"{image[i, j]} ");
            if(image[i, j] == 0) Console.Write($" "); - если выбранная ячейка содержит ноль, то печатаем пробел.
            else Console.Write($"+"); - а если выбранная ячейка содержит единицу, то печатаем +.
        }
    Console.WriteLine();
    }
}

void FillImage(int row, int col)
{
    if(pic[row, col] == 0) - если координаты точки(ячейки) содержат 0, то пикселю присваиваем единицу
    {
        pic[row, col] = 1; - пикселю присваиваем единицу, следовательно печатается +.
        FillImage(row - 1, col); - Метод вызывает сам себя(РЕКУРСИЯ), далее заложено движение по картинке для поиска пустой (с нулём) ячейки и заполняя её единицей.
        FillImage(row, col - 1);
        FillImage(row + 1, col);
        FillImage(row, col +1);

    }
}

PrintImage(pic); - выводит картинку сначала не закрашенную/не заполненную
FillImage(13, 13); - задание точки начала движения по картинки для поиска пустой ячейки.
PrintImage(pic); - выводит картинку сначала уже закрашенную/заполненную.
*/
////////// Определим факториал числа через рекурсию.
/*
int Factorial(int n)
{
    // 1! = 1
    // 0! = 1
    if (n==1) return 1;
    else return n * Factorial(n - 1);
}
Console.WriteLine(Factorial(3)); //1+2+3=6
*/

//// А если взять факториал большого числа:
/*
double Factorial(int n) // double - позволяет вмещать большие числа и преобразовывать их в n*10^x.
{
    // 1! = 1
    // 0! = 1
    if (n==1) return 1;
    else return n * Factorial(n - 1);
}
for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{1}! = Factorial(i)}"); // - будет последовательно показывать факториалы от 1 до 40.
}
*/

///// РЕКУРСИЯ числа фибоначи
// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

/*
double Fibonacсi(int n)
{
    if(n == 1 || n == 2) return 1;
    else return Fibonacсi(n-1) + Fibonacсi(n-2);
}

for (int i = 1; i < 50; i++)
{
    Console.WriteLine(Fibonacсi(i)); // или Console.WriteLine($"f({i}) = {Fibonacсi(i)}"); будет последовательно показывать значения функции числа Фибоначи.
}
*/

