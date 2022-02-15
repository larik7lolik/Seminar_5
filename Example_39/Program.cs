// Задача 39: Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

Console.Clear();
int[]array = new int[11];

 void FillArray(int [] massiv)
{
    for(int i = 0; i < massiv.Length; i++)
    {
        massiv [i] = new Random().Next(-500, 500);
    }
}
FillArray(array);
 
 int j = 0;
 Console.WriteLine("\t Номер позиции \tЭлемент массива \t Произведение пар");
 for(int i = 0; i < array.Length; i++)
 {
     j = array.Length - i - 1;
     Console.Write($"\t \t{i} \t \t{array[i]}");
     //if (i == j) Console.WriteLine($"\t\t{array[i]}"); для суммы
     //else 
     Console.WriteLine($"\t\t{array[i] * array[j]}");
 }