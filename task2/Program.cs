/* Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */


using System.Diagnostics.CodeAnalysis;

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

int GetSumNumber(int n, int m, int sum)
{
    if (n == m)
    {
        sum +=n;
        return sum;
    }
    else
    {
        sum+=n;
        n++;
        return sum =GetSumNumber(n, m, sum);
    }
}


int n = GetNumber("Введите число N: ");
int m = GetNumber("Введите число M: ");
int sum = GetSumNumber(n, m, 0);
Console.WriteLine($"{sum }");
