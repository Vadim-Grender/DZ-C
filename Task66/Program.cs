// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Summa(int M, int N)
{
    if (M > N) return 0;

    return M + Summa(M + 1, N);
}

Console.WriteLine("Введите M");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите N");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма натуральных элементов в промежутке от {M} до {N} = {Summa(M, N)}");