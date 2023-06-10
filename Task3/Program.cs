// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Akkerman(int m, int n)
{
    
    if (m == 0)
    {
        return n=n+1;
    }
    else 
    if (n==0)
    {
        return Akkerman(m-1,n=1);
    }
    else
    {
        return Akkerman(m-1,Akkerman(m,n-1));
    }


}

Console.Clear();
int m = ReadInt("Задайте знчение m:");
int n = ReadInt("Задайте знчение n:");
Akkerman(n, m);
Console.WriteLine("----------------");
Console.WriteLine($"Результат: {Akkerman(m,n)}");
