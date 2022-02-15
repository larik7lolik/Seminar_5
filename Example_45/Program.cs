// Показать числа Фибоначи
Console.Clear();
Console.Write("Сколько чисел Ф вывести?  ");
int count = int.Parse(Console.ReadLine());
int a = 1;
int b = 1;
int fibo = 0;
Console.Write($"{a}  {b}  ");
for(int i = 1; i <= count-2; i++)
{
   fibo = a + b;
   a = b;
   b = fibo;
   Console.Write($"{fibo}  ");
}
Console.WriteLine();
