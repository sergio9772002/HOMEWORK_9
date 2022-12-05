/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int getUserInt(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(message);
    Console.ResetColor();
    int userInt = Convert.ToInt32(Console.ReadLine());
    return userInt;
}
int UserNumber1 = getUserInt("Введите M");
int UserNumber2 = getUserInt("Введите N");
if (UserNumber2 > UserNumber1)
{
    int sumOfDigits = GetSumOfDigit(UserNumber1, UserNumber2);
    Console.WriteLine($"Сумма элементов равна {sumOfDigits}");
}
else
{
    int summOfDigits = GetSumOfDigit(UserNumber2, UserNumber1);
    Console.WriteLine($"Сумма элементов равна {summOfDigits}");
}

int GetSumOfDigit(int Number1, int Number2)
{
    if (Number2 == Number1 - 1)
    {
        return 0;
    }
    return Number2 + GetSumOfDigit(Number1, Number2 - 1);
}




