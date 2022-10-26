Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine()!;

if(username.ToLower() == "маша") //ToLower - позволяет исключить волияние регистра при вводе имени.
{
    Console.WriteLine("Ура, это же Маша!"); 
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}