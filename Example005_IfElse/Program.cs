Console.Write("Введите имя пользователя: ");
 string username = Console.ReadLine();

if(username.ToLower() == "наташа")
{
    Console.WriteLine("Ура, это НАТАША!");
}
else
{
     Console.Write("Привет, ");
     Console.WriteLine(username);
}
