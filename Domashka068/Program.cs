// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 29

Console.WriteLine("Задайте число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(GetAckerman(m, n));

int GetAckerman(int number1, int number2)
{
    if (number1 == 0) return number2 + 1;
    if (number1 != 0 && number2 == 0) return GetAckerman(number1 - 1, 1);
    if (number1 > 0 && number2 > 0) return GetAckerman(number1 - 1, GetAckerman(number1, number2 - 1));
    return 0;
}