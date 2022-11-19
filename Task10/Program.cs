// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трёхзначное число");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99 & num < 1000){
   int result = (num / 10) % 10;
    Console.Write($"Вторая цифра числа {num} - {result}");
}
else{
    Console.Write("Вы ввели не трехзначноечисло");
}