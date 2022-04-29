//Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число на проверку полиндрома: ");
int number = Convert.ToInt32(Console.ReadLine());

void Poli(int num)
{
    int pos1 = 0, pos5 = 0, pos2 = 0, pos4 = 0;

    pos1 = num / 10000;
    pos2 = (num / 1000) % 10;
    pos4 = (num / 10) % 10;
    pos5 = num % 10;
    
    if (pos1 == pos5 && pos2 == pos4) Console.WriteLine("Число является палиндромом");
    else Console.WriteLine("Это не палиндромом");
    Console.WriteLine($"Проверочка: {pos1} {pos2} {pos4} {pos5}");
}

Poli(number);