Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша"){
    Console.WriteLine("Привет, о это Маша!");
}
else
{
    Console.WriteLine("здравствуйте!");
    Console.WriteLine(username);
}
