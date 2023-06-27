// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}


int Main ()
{
    int number = Convert.ToInt32(Console.ReadLine());
    int sum = 0;
    while(number > 0)
    {
        sum += number%10;
        number/=10;
    }
    return sum;

}

int number = ReadInt("Введите число: ");
System.Console.WriteLine($"Сумма цифр числа {number} равна {sum}");