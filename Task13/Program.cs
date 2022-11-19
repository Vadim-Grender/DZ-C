// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введи число: ");
int num = Convert.ToInt32(Console.ReadLine());
string s = Convert.ToString(Math.Abs(num));
char[] digMas = new char[s.Length];
for (int i = 0; i < s.Length; i++)
{
    digMas[i] = s[i];
}
if (s.Length > 2)
{
    Console.WriteLine("третья цифра -> " + digMas[2]);
}
else
{
    Console.WriteLine("третьей цифры нет");
}