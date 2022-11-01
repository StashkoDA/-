// не создан тетрис

void Figure(int x, int y)
{
    for (int i = x - 1; i <= x + 1; i++)
    {
        for (int j = y - 1; i <= y + 1; j++)
        {
            Console.SetCursorPosition(i, j);
            Console.Write("+");
        }
    }
}
int x = 10;
int y = 2;

// логика отрисовки всего
new Thread(() =>
{
    while (true)
    {
        Figure(x, y);
        Thread.Sleep(500);
        y++;
        if (y > 10) y = 1;

        
    }
}).Start();

Console.CursorVisible = false;

// Логика проверки нажатия кнопок
while (true)
{
    var key = Console.ReadKey(true).Key;
    if (key == ConsoleKey.LeftArrow)
    {
        x--;
        Figure(x, y);
    }
    if (key == ConsoleKey.RightArrow)
    {
        x++;
        Figure(x, y);
    }
}