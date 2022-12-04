// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите размерность двумерного массива m x n");
Console.WriteLine("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = new Random().Next(0, 11);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите позицию нужного элемента");
Console.WriteLine("Введите номер строки: ");
int k = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int l = Convert.ToInt32(Console.ReadLine());
if (k <= m && l <= n)
{

    Console.WriteLine("Ваше число " + matrix.GetValue(k - 1, l - 1));
}
Console.WriteLine("Нет такого элемента");