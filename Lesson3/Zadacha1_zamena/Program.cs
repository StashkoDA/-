// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить на большие буквы "К", а большие  "С"
// заменить на маленькие "с".

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винцегероде, "
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012345
// S[3] это символ "r"

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ', '|'); //заменяем пробелы на чёрточки
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К'); //заменяем маленькие "к" на большие "К" в предыдущем тексте. Приставку string не используем для второго действия
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'ы', 'Ы'); //заменяем маленькие "ы" на большие "Ы" в предыдущем тексте. Приставку string не используем также
Console.WriteLine(newText);