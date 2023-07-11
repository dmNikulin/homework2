//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

Console.Clear();

Console.Write("Введите число: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day > 7 || day == 0) Console.WriteLine("Неизвестное значение");

else if (day == 7 || day == 6) Console.WriteLine("Выходной!");

else Console.WriteLine("Будний день.");
