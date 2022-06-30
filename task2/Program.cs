/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
Console.WriteLine("Hello, World!");
Console.WriteLine("Введите число");
string number = Console.ReadLine();

if (number.Length >= 3)
{
    char result = number[2];
    Console.WriteLine($"Третья цифра введенного числа = {result}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}