Console.Write("Введите имя пользователя:  ");
string username = Console.ReadLine();
if(username.ToLower() == "vova")
{
    Console.WriteLine("Привет, Вовка!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}

