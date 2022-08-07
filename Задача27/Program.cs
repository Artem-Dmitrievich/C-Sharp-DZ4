// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
Console.Write("Входящее число: ");
int a = Convert.ToInt32(Console.ReadLine());
int summa = 0;

while (a > 0)
{
  int num = a % 10;
  a = a / 10;
  summa = summa + num;
}
Console.WriteLine("Сумма: " + summa);