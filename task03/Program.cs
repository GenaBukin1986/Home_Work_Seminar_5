/*
Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/
// Метод создания массива вещественных чисел в заданном диапазоне
double[] Arrs(int num, int nummin, int nummax)
{
    double[] array = new double[num];
    Random nrmd = new Random();
    Random rmd = new Random();
    for (int i = 0; i < num; i++)
    {
        array[i] = nrmd.Next(nummin, nummax) - Math.Round(rmd.NextDouble(), 2);
    }
    return array;
}
/* 
Создаем метод, который находит минимальное
и максимальное значение массива, а затем рассчитывает их разницу
*/
double[] DiffMinMax(double[] arr)
{
    double min = arr[0];
    double max = arr[1];
    foreach (double item in arr)
    {
        min = item < min ? item : min;
        max = item > max ? item : max;
    }
    double[] newarrs = { min, max, max - min };
    return newarrs;
}

void PrintResult(double[] massiv)
{
    Console.WriteLine();
    Console.WriteLine($"Максимальный элемент массива {massiv[1]:f2}");
    Console.WriteLine($"Минимальный элемент массива {massiv[0]:f2}");
    Console.WriteLine($"Разница между максимальным и минимальным {massiv[1]:f2} - {massiv[0]:f2} = {massiv[2]:f2}");
    Console.WriteLine();
}

Console.Clear();
double[] ars = Arrs(5, 1, 45);
// Вывод массива случайных вещественных чисел в заданном диапазоне
Console.WriteLine($"Массив случайных чисел {String.Join(" ", ars)}");

double[] argen = DiffMinMax(ars);
PrintResult(argen);