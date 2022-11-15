// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numB = Convert.ToInt32(Console.ReadLine());
if ( numA > numB ) {
Console.WriteLine($"max = {numA} min = {numB}");
}
else if ( numA < numB ){
Console.WriteLine($"max = {numB} min = {numA}");
}
else {
Console.WriteLine("Введены одинаковые числа");
}