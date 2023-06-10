// Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadInt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Num(int M, int N, int sum)
{
    if (M <= N)
    {
        sum = sum + M;
        return Num(M + 1, N, sum);

    }
    Console.WriteLine("-----------------");
    Console.WriteLine($"Сумма чисел: {sum}");
    return sum;
}

Console.Clear();
int sum = 0;
int M = ReadInt("Задайте число M: ");
int N = ReadInt("Задайте число N: ");
Num(M, N, sum);

