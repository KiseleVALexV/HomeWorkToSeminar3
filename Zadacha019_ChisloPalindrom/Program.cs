// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void CheckForPalindrome(int number)
{
    bool mean = true;
    int length = 1;
    int BitDepth = 1;
    int number1 = number;
    int number2 = number;
    // Определение разрядности числа (количества цифр) 
    while (number1 >= 10)
    {
        number1 = number1 / 10;
        length ++;
        BitDepth = BitDepth * 10;
    }
    // Сравнение цифр с противоположных сторон числа
    number1 = number;
    for (int i = 1; i < length; i ++ )
    {
        if (number1 % 10 != number2 / BitDepth)
        {
            mean = false;
        }
        number2 = number2 % BitDepth;
        number1 = number1 / 10;
        BitDepth = BitDepth / 10;
    }
    if (mean == true && number >= 0)
        Console.WriteLine($"Число является палиндромом");
    else
        Console.WriteLine($"Число не является палиндромом");
}

int number;
Console.WriteLine("Введите натуральное число : ");
string EntSign = Console.ReadLine();

while (!Int32.TryParse(EntSign, out number))
{
    Console.WriteLine($"Неправильный ввод. Введите натуральное число : ");
    EntSign = Console.ReadLine();
}

CheckForPalindrome(number);

// Второй вариант с числами, имеющими дробную часть. Если принимать в широком смысле,
// что числа типа 34,43 тоже являются палиндромами
// Более короткое решение c действиями в дробной части не работает из-за некорректного действия NET с дробной частью 
// Данное решение работает
double NewNumber;
Console.WriteLine("Вариант с дробными числами. Введите число : ");
NewNumber = Convert.ToDouble(Console.ReadLine());

bool NewCheckForPalindrome(double number)
{
    bool mean = true;
    int length = 1;
    int BitDepth = 1;
    int number1 = (int)number;
    int number2 = (int)number;
    // Определение разрядности целой части числа
    while (number1 >= 10 )
    {
        number1 = number1 / 10;
        length ++;
        BitDepth = BitDepth * 10;
    }
    number1 = (int)number;
    // Проверка на отрицательность
    if (number < 0)
        mean = false;
    // Сравнение количества цифр справа и слева от запятой
    if (number != (int)number && number * BitDepth * 10 != (int)(number * BitDepth * 10))
        mean = false;
    // Приведение числа к целому виду
    if (number != (int)number && number * BitDepth * 10 == (int)(number * BitDepth * 10))
        {
            number1 = (int)(number * BitDepth * 10);
            number2 = (int)(number * BitDepth * 10);
            length = length * 2;
            BitDepth = BitDepth * BitDepth * 10;
        }
    // Сравнение цифр справа и слева
    for (int i = 1; i < length; i ++ )
    {
        if (number2 % 10 != number1 / BitDepth)
        {
            mean = false;
        }
        number1 = number1 % BitDepth;
        number2 = number2 / 10;
        BitDepth = BitDepth / 10;
    }
    return mean;
}

bool mean = NewCheckForPalindrome(NewNumber);
if (mean == true)
    Console.WriteLine($"Число является палиндромом");
else
    Console.WriteLine($"Число не является палиндромом");
Console.ReadKey();





