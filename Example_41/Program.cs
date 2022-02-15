// Задача 41. Выяснить являются ли три числа сторонами треугольника
//Решение: неравенство треугольника: если есть три числа a,b,c,
// то они являются сторонами треугольника если (a+b) > c и (b+c) > a и (a+c) >b
Console.Clear();
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите число: ");
int c = int.Parse(Console.ReadLine());
if ((a+b) > c && (b+c) > a && (a+c) >b) Console.WriteLine(" Да, это стороны треугольника");
else Console.Write("Нет, не являются");
Console.WriteLine();