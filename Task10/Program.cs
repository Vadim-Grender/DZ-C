// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трёхзначное число");
int numA = Convert.ToInt32(Console.ReadLine());
if (numA > 99 & numA < 1000){
   int result = (numA / 10) % 10;
    Console.Write($"Вторая цифра числа {numA} - {result}");
}
else{
    Console.Write("Вы ввели не трехзначноечисло");
}