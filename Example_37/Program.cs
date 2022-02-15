// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

Console.Clear();
int[]array = new int[123];

 void FillArray(int [] massiv)
{
    for(int i = 0; i < massiv.Length; i++)
    {
        massiv [i] = new Random().Next(10, 99);
        
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
int counter = 0;
for (int i = 0; i < array.Length; i++)
{
    if(array[i] >= 10 && array[i] <= 99) counter++;
}
Console.WriteLine($"\n количество элементов из отрезка[10, 99]-{counter}");