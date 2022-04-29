//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число от 1 до 10: ");
int cube = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= cube; i++)
{
    Console.WriteLine($"{i}^3 = {Math.Pow(i, 3)}");
}