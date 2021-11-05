Console.Write("Введите имя:");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Это же Избранная!!!");
}
else 
{
    Console.Write("Hello, ");
    Console.Write(username);
}
