


string path = @"C:\Users\Home\Desktop\Kod_sharp\Seminar8\Zadacha_s_file\file1.txt";
string text = File.ReadAllText(path); // Результат считывания файла будет строка.
                                      // Считывание данных с файла.
                                      // Patch - путь к файлу.
Console.WriteLine("Печать текста из файла:");
Console.WriteLine(text); // Печать текста из файла.

Console.WriteLine("Нахождение позиции перехода на новую строку в тексте файла:");
Console.WriteLine(text.IndexOf("\n")); // Нахождение перехода на новую строку (положения разделителя).
                                       // Деление строки - \n или Environment.NewLine.
                                       
int pos = text.IndexOf("\n"); // Значение положения символа разделителя


/*
Console.WriteLine("Разбиение текста на строки:");
string[] lines = text.Split("\n"); // Массив строк.
// string[] lines = File.ReadAllLines(path); // Массив строк иначе, если в файле построчная инф-ция.

for (int i = 0; i < lines.Length; i++)
{
    Console.WriteLine($"{i + 1}: {lines[i]}"); // Деление по строкам массива с указанием порядкового номера.
}

// Не использовать пустые строки в файле, если его необходимо анализировать.
// Split - это символоразделитель.
*/

Console.WriteLine("Разбиение строки:");
int a = 0, b = 0;
string[] lines = File.ReadAllLines(path);
for (int i = 0; i < lines.Length; i++)
{
    string[] symbols = lines[i].Split('='); // Обработка строк в файле. Строка - это тоже массив и её можно разбить на запчасти.

    // До знака "=" имя значения, после - его значение.

    for (int j = 0; j < symbols.Length; j++)
    {
        Console.WriteLine($"{i + 1}: >>{symbols[j].Trim()}<<"); // Деление по строкам массива с указанием порядкового номера.
                                                                // Trim() - исключение пробелов.
    }
    // Проверка: если символ [0] равен "а", то в значение "а" положить его значение из файла.
    if (symbols[0].Trim() == "a")
    {
        a = Convert.ToInt32(symbols[1].Trim());
    }

    if (symbols[0].Trim() == "b")
    {
        b = Convert.ToInt32(symbols[1].Trim());
    }
}
Console.WriteLine("Печать проверки соответствия значений а и b:");
Console.WriteLine($"a = {a}  b = {b}");

// Запись результата в новый файл "output.db":
File.WriteAllText("output.db", $"Результат = {a * b}");