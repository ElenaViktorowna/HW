//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
int Num = int.Parse(Console.ReadLine());
if (Num<100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    while(Num>=1000)
    {
        Num = Num/10;
    }
    int thirdNumber = Num %10;
    Console.WriteLine($"Третья цифра числа -> {thirdNumber}");
}