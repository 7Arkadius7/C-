﻿Console.WriteLine("Пожалуйста, введи свое имя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же Маша!!!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}