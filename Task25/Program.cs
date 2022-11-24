// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Write("Введите число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральную степень: ");
int numB = Convert.ToInt32(Console.ReadLine());
int numC = 1;
for(int i = 0; i < numB; i++)
{
    numC *= numA;    
}
Console.WriteLine($"Число {numA} в степени {numB} = {numC}");