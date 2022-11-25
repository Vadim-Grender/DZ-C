// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
Console.Write("Введите кол-во элементов: ");
string? count = Console.ReadLine();
int[] array = new int[0];
if (int.TryParse(count, out int tryCount) & tryCount > 0)
{
    array = new int[tryCount];
    for (int i = 0; i < tryCount; i++)
    {
        Console.Write($"Введите число {i + 1}: ");
        string? digit = Console.ReadLine();
        if (int.TryParse(digit, out int tryDigit))
        {
        array[i] = tryDigit;
        }
        else
        {
            Console.WriteLine("Введено нечисловое значение, значение  = 0"); 
        }
    }
    Console.Write('[' + string.Join(", ", array) + ']');
}
else
{
    Console.WriteLine("Введено недопустимое значение");
}
