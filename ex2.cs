//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;
int N = 0;

if (number < 100) Console.WriteLine("Третьей цифры нет!");

else if (number >= 100 && number <= 999)
{
    result = number % 10;
}

else if (number >= 1000 && number <= 9999)
{
    N = 10;
    result = (number / N) % 10;
}

else if (number >= 10000 && number <= 99999)
{
    N = 100;
    result = (number / N) % 10;
}

else if (number >= 100000 && number <= 999999)
{
    N = 1000;
    result = (number / N) % 10;
}

Console.WriteLine($"Третья цифра вашего числа: {result}");
