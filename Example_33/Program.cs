// Задача 33: Задать массив из 12 элементов, заполненных
//числами из [0,9]. Найти сумму положительных/отрицательных элементов массива.
/* int[] array = new int[12];
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

Console.WriteLine("Сумма отрицательных элементов массива равна " + summinus); */

Console.Clear();
int[]array = new int[12];
 void FillArray(int [] massiv)
{
    for(int i = 0; i < massiv.Length; i++)
    {
        massiv [i] = new Random().Next(-500, 501);
    }
}
FillArray(array);
 void PrintArray(int[]massiv)
{
    for(int i = 0; i < massiv.Length; i++)
    {
       Console.Write($"{massiv[i]} ");
    }
}
PrintArray(array);
int positive = 0;
int negative = 0;
for(int i = 0; i < array.Length; i++)
{
    if(array[i] > 0) positive += 1;
    else negative += 1;
}
Console.WriteLine($"В заданном массиве {positive} положительных чисел и {negative} отрицательных");
Console.WriteLine();