// Задача 33: Задать массив из 12 элементов, заполненных
//числами из [0,9]. Найти сумму положительных/отрицательных элементов массива.
int[] array = new int[12];
int i = 0;
while (i < 12)
{
    array[i] = new Random().Next(-10, 10);
    Console.Write(array[i] + " ");
    i++;
}
Console.WriteLine();
int sum = 0;
int summinus = 0;
int a = 0;
while (a < 12)
{
    if (array[a] >=0)
    {
        sum = sum + array[a];
    }
    else
    {
       summinus = summinus + array[a];
    }
      a++;  
}   
Console.WriteLine("Сумма положительных элементов массива равна " + sum);

Console.WriteLine("Сумма отрицательных элементов массива равна " + summinus);

