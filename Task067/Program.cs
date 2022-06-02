// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = Numbers(number);
Console.WriteLine(result);

int Numbers(int number)
{
    if (number > 0)
    {
        return number%10 + Numbers(number/10);
    }
    return 0;
}
