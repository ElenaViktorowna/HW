// Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine()!);
if(number/10000 == number%10 & number%10000/1000 == number%100/10)
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}
