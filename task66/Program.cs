// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в
//  промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int n, m, s=0;
Console.Write("Введи значение N от: ");
n = Convert.ToInt16(Console.ReadLine());
Console.Write("Введи значение M до : ");
m = Convert.ToInt16(Console.ReadLine());
for (int i = n; i <= m; i++)
    s += i;
Console.WriteLine($"Сумма равна - > {s}");
