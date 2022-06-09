// Задайте значение N. Напишите программу, которая выведет все
//натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.WriteLine("Введите значение n: ");
int n = int.Parse(Console.ReadLine());

void NaturalNumbers(int n)
{
    if (n == 1) return;
    n--;
    NaturalNumbers(n);
    Console.Write($"{n + 1} ");
}
NaturalNumbers(n);
