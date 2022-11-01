int n = 8000;
int[,] m = new int[n, n];
int s = 0;

// time start
DateTime ts = DateTime.Now; // определим время начала операции
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        s += m[i, j];
    }
}
// time end
DateTime te = DateTime.Now; // определим время окончания операции
Console.WriteLine((te - ts).TotalMilliseconds);