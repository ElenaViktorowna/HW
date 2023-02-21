// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

Console.Write("Введите номер дня: ");
int number = int.Parse(Console.ReadLine()!);
if ((number >= 1) && (number <= 7))
{
    if(number ==6 || number==7)
    {
        Console.WriteLine("ДА");
    }
    else
    {
        Console.WriteLine("НЕТ");
    }    
}
else
{
    Console.WriteLine("НЕТ ТАКОГО ДНЯ");
}