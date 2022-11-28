// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях(индексах).
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] FillArray(int size)
{

    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }
    return array;
}

Console.Write("Введите длину массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(num);
int sum = 0;
for (int j = 1; j < array.Length; j += 2)
{
    sum += array[j];
}
Console.WriteLine('[' + string.Join(", ", array) + ']');
Console.WriteLine($"Сумма элементов, стоящих на нечётных индексах -> {sum}");