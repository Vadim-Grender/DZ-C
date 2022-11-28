// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] FillArray(int size)
{

int[] array = new int[size];
for(int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(100,1000);
}
return array;
}

Console.Write("Введите длину массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(num);
int count = 0;
for(int j = 0; j < array.Length; j++)
{
    if (array[j] % 2 == 0) 
    {
        count++;
    }

}
Console.WriteLine('[' + string.Join(", ", array) + ']');
Console.WriteLine($"Кол - во четных чисел в массиве -> {count}");