//35. Определить, присутствует ли в заданном массиве, некоторое число
/* int[] mass = new int[8];
Random rnd = new Random();

for(int i = 0; i < mass.Length; i++)
{
    mass[i]= rnd.Next(-10,10);
    Console.Write(mass[i] + " ");
}
Console.WriteLine();
for (int j = 0; j < mass.Length; j++)
{
    if(mass[j] == 7)
    {
    Console.WriteLine("Число 7 есть");
    break;
    }
} */

//int[] = new Random().Next(-10,10);

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

Console.WriteLine();
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
int b = Array.IndexOf(array, a);
if (b==-1) Console.WriteLine("Данное число отсутствует в массиве");
else Console.WriteLine($"Данное число есть в массиве с позицией{b}");