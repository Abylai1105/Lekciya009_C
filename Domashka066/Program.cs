// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Задайте число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int c = m;
if (m < 0) m = 0;
if (n < 0) n = 0;

int result = GetNumbers(m , n ,c);
Console.WriteLine(result);

static int GetNumbers(int start, int end, int buffer)
{
    if (buffer < end)
    {
        if (buffer == end) return start;
        return GetNumbers(start += end, end - 1, buffer);
    }
    if (buffer == end) return start;
    return GetNumbers(start += end, end + 1, buffer);
}

