Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "selmarionx")
{
    Console.WriteLine("Приветствуею тебя о ВЕЛИКИЙ ");
}
else 
{
    Console.Write("о привет смертный ");
    Console.WriteLine(username);
}