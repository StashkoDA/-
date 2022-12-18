

void PrintArray(string[] arrString)
{
    Console.Write("[");
    for (int i = 0; i < arrString.Length - 1; i++)
    {
        Console.Write(arrString[i] + ", ");
    }
    Console.Write(arrString[arrString.Length - 1] + "] -> ");
}

string[] GetMassive(string[] arrString)
{
    int j = 0;
    for (int i = 0; i < arrString.Length; i++)
    {
        string message = arrString[i];
        if (message.Length < 4) j++;
    }
    
    string[] resArr = new string[j];
    int q = 0;
    for (int k = 0; k < arrString.Length; k++)
    {
        string message = arrString[k];
        if (message.Length < 4)
        {
            resArr[q] = arrString[k];
            q++;

        }
    }
    return resArr;
}

void PrintResult(string[] arrString)
{
    Console.Write("[");
    for (int i = 0; i < arrString.Length - 1; i++)
    {
        if (arrString[i] != String.Empty)
        {
            Console.Write(arrString[i] + ",");
        }
    }
    Console.Write(arrString[arrString.Length - 1] + "]");
    Console.WriteLine();
}

string[] arrayString = { "qwer", "a6s", "(*)", "1@", "$", "next" };
PrintArray(arrayString);
string[] resultArr = GetMassive(arrayString);
PrintResult(resultArr);
