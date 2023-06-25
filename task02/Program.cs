/*
Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

// Метод для создания одномерного массива, заполненного случайными числами
int[] Array(int num)
{
    int[] arrs = new int[num];
    Random rmd = new Random();
    for (int i = 0; i < num; i++)
    {
        arrs[i] = rmd.Next(0, 150);
    }
    return arrs;
}

// Метод расчитывает сумму элементов, имеющих нечетные позиции
int SumArray(int[] massiv)
{
    int sum = 0;
    for (int i = 0; i < massiv.Length; i++)
    {
        sum += i % 2 != 0 ? massiv[i] : 0;
    }
    return sum;
}

Console.Clear();
int[] numbers = Array(5);
Console.WriteLine($"Массив случайных чисел {String.Join(" ", numbers)}");
Console.WriteLine();
int result = SumArray(numbers);
Console.WriteLine($"Сумма элементов, имеющих нечетный индекс равна {result}");