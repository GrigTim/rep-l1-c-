Console.Write("Введите имя пользователя ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine ("Ура, это она");
}
else
{
    Console.Write("Hi, ");
    Console.WriteLine(username);
}