//Задача 2.Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int num1, num2;
Console.Write("Введите первое число: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
            {
                Console.WriteLine("Первое число " + num1 + " больше чем второе " + num2);
            }
            else
            {
                Console.WriteLine("Второе число " + num2 + " больше чем первое " + num1);
            }
