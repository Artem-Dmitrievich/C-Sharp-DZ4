﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
Console.Write("Число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Число B: ");
int b = Convert.ToInt32(Console.ReadLine());
for (int i = a; i <= a; i++)
{
    Console.Write(Math.Pow(i , b) + " ");
} 
