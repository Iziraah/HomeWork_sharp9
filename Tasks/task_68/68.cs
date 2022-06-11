// Напишите программу вычисления функции Аккермана с помощью
//рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 29

Console.WriteLine("Введите значение n: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение m: ");
int n = int.Parse(Console.ReadLine());

int FunctionAkk(int m, int n)
{
    if (m == 0)
    {
    return n + 1;
    }
    else if (n == 0 && m > 0)
    {
    return FunctionAkk(m - 1, 1);
    }
    else
    {
    return FunctionAkk(m - 1, FunctionAkk(m, n - 1));
    }
}
FunctionAkk(m, n);
Console.WriteLine(FunctionAkk(m, n));
