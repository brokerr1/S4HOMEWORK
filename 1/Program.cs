/*
Напишите цикл, который принимает на вход
два числа (A и B) и возводит число A в натуральную
степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int NatStep(int a, int b)
{
    return Convert.ToInt32(Math.Pow(a,b));
}
int result = NatStep(numberA, numberB);
Console.WriteLine($"Число A в степени B = {result}");