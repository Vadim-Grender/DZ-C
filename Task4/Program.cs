// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int numC = Convert.ToInt32(Console.ReadLine());
if ( numA > numB && numA > numC){
Console.WriteLine($"Максимальное из чисел {numA}");
}
else if ( numB > numA && numB > numC){
Console.WriteLine($"Максимальное из чисел {numB}");
}
else {
Console.WriteLine($"Максимальное из чисел {numC}");
}