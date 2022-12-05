/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
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
if (UserNumber1 >= 0 && UserNumber2 >=0)
{
    int GetAkkerman(int M, int N)
    {
            if (M == 0)
            {
                return N + 1;
            } 
            if (N == 0)
            {
                return GetAkkerman(M - 1, 1);
            }
            return GetAkkerman(M - 1, GetAkkerman(M, N - 1));
 
    }
    int functionAkkerman = GetAkkerman(UserNumber1, UserNumber2);
    Console.WriteLine($"Функция Аккермана для M и N равна {functionAkkerman}");
}
else
{
    Console.WriteLine("M и N должны быть >= 0");
}
