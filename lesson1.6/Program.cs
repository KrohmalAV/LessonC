﻿Console.Write("Введите ваше имя: ");
string name = Console.ReadLine()!;
if(name.ToLower() == "антон")
{
    Console.WriteLine("Добро пожаловать, хозяин!");
}
else
{
    Console.Write("Здравствуйте, ");
    Console.WriteLine(name);
}