// Задайте массив вещественных(тип double) чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] FillArray(int size)
{

    double[] array = new double[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(new Random().NextDouble() * 10, 3);
    }
    return array;
}

Console.Write("Введите длину массива: ");
int num = Convert.ToInt32(Console.ReadLine());
double[] array = FillArray(num);
double max = array.Max();
double min = array.Min();
double result = max - min;
Console.WriteLine('[' + string.Join(", ", array) + ']');
Console.WriteLine($"Максимальное значение = {max} Минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементов массива -> {result}");