// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"


Console.WriteLine("Задайте число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int result = Rekurs(n);
Console.WriteLine(result);

int Rekurs(int number)
{
    if (number == 1)
        return 1;
    int temp = (Rekurs(number - 1));
    Console.Write(temp + ", " );
    return number;
}