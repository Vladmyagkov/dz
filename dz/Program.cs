﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if(num>num2)
// {
//     Console.Write("max=");
//     Console.Write(num);
// }
// else if(num==num2)
// {
//     Console.Write("Они равны");
// }
// else
// {
//     Console.Write("max=");
//     Console.Write(num2);
// }


// _______________________________________________________________________

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int num2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int num3 = Convert.ToInt32(Console.ReadLine());

// int max = num;

// if(num>max) max=num;
// if(num2>max) max=num2;
// if(num3>max) max=num3;

// Console.WriteLine(max);

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.WriteLine("Введите число : ");
// int num = Convert.ToInt32(Console.ReadLine());
// if ((num % 2) == 0)
// {
// Console.WriteLine("Четное");
// }
// else
// {
// Console.WriteLine("Нечетное");
// }

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int evenNumber = 2;

// if(num > 1)
// {
// while(evenNumber <= num)
// {
// Console.Write(evenNumber);
// evenNumber = evenNumber + 2;
// }
// }