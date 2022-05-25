/*
Напишите программу, которая задаёт массив целых чисел и выводит их на экран.
Размер массива определяется пользователем.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[20];
Random MyRandom = new Random();

Console.WriteLine("Сформированный массив:");
for (int i = 0; i < array.Length; i++)
{
    array[i] = MyRandom.Next(0, 20);
    Console.Write("{0} ", array[i]);
}
