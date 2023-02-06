Console.Clear();

void NaturalGapPrint(int start, int end)
{
    Console.Write($"{start} ");
    if (start == end) return;
    else
    {
        NaturalGapPrint(start - 1, end);
    }
}
int NaturalGapSum(int start, int end)
{
    int sum = 0;
    if (start > end)
    {
        int temp = start;
        start = end;
        end = temp;
    }
    else
    {
        if (start == end) return end;       //Взяла в диапазоне чисел, включая "границы"
        else {
            sum = start+NaturalGapSum(start + 1, end);
        }
    }
    return sum;
}
// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
Console.WriteLine("Введите значение N:");
int N = Convert.ToInt32(Console.ReadLine());
NaturalGapPrint(N,1);
*/
//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите значение N:");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение M:");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма натуральных элементов в введенном промежутке = {NaturalGapSum(N, M)}");

//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.