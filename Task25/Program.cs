// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}


int ExpNumbers(int A, int B)
{
    int exp = 1;
    for(int i = 1; i <= B; i++)
    {
        exp = exp * A;
    }
    return exp;
}

//--------------основная часть кода---------------
int numberA = ReadInt("Введите число A: ");
int numberB = ReadInt("Введите число B: ");

int exp = ExpNumbers(numberA,numberB);

System.Console.WriteLine($"Число {numberA} в степени {numberB} равно {exp}");