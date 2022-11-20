// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.WriteLine("Введите пятизначное число: ");
string num = Console.ReadLine();
char[] revNum = num.ToCharArray();
Array.Reverse(revNum);
string finalNum = new string(revNum);
if (num.Length == 5)
{
    if (num == finalNum)
    {
        Console.WriteLine("Данная запись является палиндромом");
    }
    else
    {
        Console.WriteLine("Данная запись не является палиндромом");
    }
}
else
    {
        Console.WriteLine("Введено не пятизначное число");
    }