// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.Write("Введите колличество элементов: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[number];

for (int i = 0; i < array.Length; i++)
{
    Console.Write("Введите число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

int count = 0;
for (int j = 0; j < array.Length; j++)
{
    if (array[j] > 0)
    {
        count++;
    }

}
Console.WriteLine('[' + string.Join(", ", array) + ']');
Console.WriteLine($"Колличество чисел больше 0 -> {count}");