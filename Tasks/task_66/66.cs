// Задайте значения M и N. Напишите программу, которая найдёт сумму
//натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

Console.WriteLine("Введите значение n: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение m: ");
int n = int.Parse(Console.ReadLine());

int NumSum(int n, int m)
{
  if (n == m) return n;
  if (m < n) return NumSum(n, m + 1) + m;  
  if (m > n) return NumSum(n + 1, m) + n;
  else return 0;
}
NumSum(n, m);
Console.WriteLine($"Сумма натуральных элементов от {m} до {n} = {NumSum(n, m)}");
