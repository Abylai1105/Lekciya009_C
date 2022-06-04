// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Задайте число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int result = Rekurs(n);
Console.WriteLine(result);

int Rekurs(int number)
{
    if (number == 1)
        return n;
    int temp = (Rekurs(number - 1));
    Console.Write(temp + ", " );
    return number;
}
