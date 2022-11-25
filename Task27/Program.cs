// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int numA = Convert.ToInt32(Console.ReadLine());
int counter = Convert.ToString(numA).Length;
int result = 0;

for (int i = 0; i < counter; i++)
{
    result = result + numA % 10;
    numA = numA / 10;
}
Console.WriteLine(counter);
Console.Write("Сумма чисел = " + result);