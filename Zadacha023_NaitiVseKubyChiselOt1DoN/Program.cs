// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void PrintSquaresToConsole(int n)
{
    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine(i * i * i);
    }
}

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Кубы чисел от 1 до введенного :");
PrintSquaresToConsole(n);
