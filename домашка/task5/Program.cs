//Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.

int num = new Random().Next(100, 1000);
Console.WriteLine(num);
int number = num % 100;

int N = num % 100/10;
Console.WriteLine(N);

