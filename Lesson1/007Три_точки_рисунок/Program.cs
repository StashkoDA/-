Console.Clear(); // для очистки терминала постоянно
//Console.SetCursorPosition(10, 4); - задание отступов 10 слева, 4 справа.
//Console.WriteLine("+"); - рисование плюсиками, ввод "+" в заданной точке. 
// задача: взять три точки на плоскости. выбрать две, найти середину между ними - точку. далее выбрать другие две точки и т.д.
// при выполнении операции 10 000 раз должен получиться рисунок - Треугольник Серпинского.

int xa = 40, ya = 1,
    xb = 1, yb = 30,
    xc = 80, yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");


int x = xa, y = xb; // задаём точку
int count = 0;
while(count < 10000)
{
    int what = new Random().Next(0, 3); // выбор случайнго числа, определяющее одну из трёх точек 
    if (what == 0) // для первой точки 
    {
        x = (x + xa) / 2; // определяем середину отрезку по иксу
        y = (y + ya) / 2; // определяем середину отрезку по игреку
    }

    if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }

    if (what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition(x,y);
    Console.WriteLine("+");
    count = count + 1;
}
