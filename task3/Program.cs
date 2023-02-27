/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

int GetNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ошибка ввода. Повторите ввод");
        }
    }
    return result;
}

int GetAckermannFunction (int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return GetAckermannFunction(m - 1, 1);
    if (m > 0 && n > 0) return GetAckermannFunction(m - 1, GetAckermannFunction(m, n - 1));
return GetAckermannFunction(m, n);
}


int m = GetNumber("Введите число M: ");
int n = GetNumber("Введите число N: ");
int AckermannFunction = GetAckermannFunction (m, n);
Console.WriteLine ($"Функция Аккермана А({m}, {n}) = {AckermannFunction}");