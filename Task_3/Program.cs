/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным
(делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет*/

Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());
int numA = number % 2;

if (numA == 1)
    Console.WriteLine($"{number} - является не чётным числом");
if (numA == -1)
    Console.WriteLine($"{number} - является не чётным числом");
if (numA == 0)
    Console.WriteLine($"{number} - является чётным числом");
