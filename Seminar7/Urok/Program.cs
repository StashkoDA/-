// округление после запятой: 123.46

double d = 123000.456789012;
Console.WriteLine(string.Format("{0:F2}", d));
// или интерполяция: 123.4568
Console.WriteLine($"{d:F4}");

// или с указанием "руб":
Console.WriteLine($"{d:F4} руб");

// округление с пробелом между знаками
Console.WriteLine(d.ToString("### ###.### ###"));

