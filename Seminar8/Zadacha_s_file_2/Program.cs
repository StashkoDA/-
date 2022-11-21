// Создание файл со списком: имя, фамилия, возраст из файла с именами и файла с фамилиями
/*
string[] fNames = File.ReadAllLines("First_names.txt"); // Задание имени.
string[] lNames = File.ReadAllLines("Last_names.txt"); // Задание фамилии.

string output = String.Empty; // пустая строка
for (int i = 0; i < 1000; i++)
{
    string manFName = fNames[Random.Shared.Next(fNames.Length)]; // случайный выбор имени из списка.
    string manLName = lNames[Random.Shared.Next(lNames.Length)]; // случайный выбор имени из списка.
    int age = Random.Shared.Next(18, 78); // задаём возраст.
    string currentMan = $"{manFName};{manLName};{age};\n"; // присвоение имени, фамилии и возраста с переходом на новую строчку.
    output += $"{currentMan}\n";
}

File.WriteAllText("result.csv", output); // Создание файла с новым списком.
*/
// или
/*
string[] fNames = File.ReadAllLines("First_names.txt");
string[] lNames = File.ReadAllLines("Last_names.txt");

string[] output = new string[1000]; //массив из строк списка
for (int i = 0; i < output.Length; i++)
{
    string manFName = fNames[Random.Shared.Next(fNames.Length)]; // случайный выбор имени из списка.
    string manLName = lNames[Random.Shared.Next(lNames.Length)]; // случайный выбор имени из списка.
    int age = Random.Shared.Next(18, 78); // задаём возраст.
    output[i] = $"{manFName};{manLName};{age};"; // прсвоение имени, фамилии и возраста с переходом на новую строчку.
}

File.WriteAllLines("result2.csv", output);
*/

// или с добавлением заголовка:

string[] fNames = File.ReadAllLines("First_names.txt");
string[] lNames = File.ReadAllLines("Last_names.txt");

string[] output = new string[1000]; //массив из строк списка

File.WriteAllText("result3.csv", "ID;Имя;Фамилия;Возраст;\n"); // Создание файла с заголовками.

for (int i = 0; i < output.Length; i++)
{
    string manFName = fNames[Random.Shared.Next(fNames.Length)]; // случайный выбор имени из списка.
    string manLName = lNames[Random.Shared.Next(lNames.Length)]; // случайный выбор имени из списка.
    int age = Random.Shared.Next(18, 78); // задаём возраст.
    output[i] = $"{i + 1};{manFName};{manLName};{age};"; // прсвоение имени, фамилии и возраста с переходом на новую строчку.
}

File.AppendAllLines("result3.csv", output); // Добавление в файл списка людей.