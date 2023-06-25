/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
// Метод создания массива положительных трехзначных случайных чисел
int[] RandomNumbers(int num)
{
    int[] array = new int[num];
    Random rmd = new Random();
    for (int i = 0; i < num; i++)
    {
        array[i] = rmd.Next(100, 1000);
    }
    return array;
}
// Метод подсчета количества четных чисел в массиве
int ReturnCount(int[] arrs)
{
    int count = 0;
    foreach (int item in arrs)
    {
        count += item % 2 == 0 ? 1 : 0;
    }
    return count;
}
Console.Clear();
int[] arrs = RandomNumbers(99);
Console.WriteLine(String.Join(" ", arrs));
int nums_two = ReturnCount(arrs);
Console.WriteLine();
Console.WriteLine($"Количество четных чисел в массиве равно {nums_two}");
