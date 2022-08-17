/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

Console.WriteLine("Введите размеры массива");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[m, n];
 
for (int i = 0; i < arr.GetLength(0); i++) 
{
    for (int j = 0; j < arr.GetLength(1); j++)
        arr [i, j] = Convert.ToInt32(new Random().Next(0,10));  
}
 
for (int i = 0; i < arr.GetLength(0); i++) 
{
    for (int j = 0; j < arr.GetLength(1); j++)
        Console.Write(arr[i,j] + " ");
        Console.WriteLine();
}
 
 Console.WriteLine("Введите координаты");
 int a = Convert.ToInt32(Console.ReadLine());
 int b = Convert.ToInt32(Console.ReadLine());
 if (a>m && b>n)
 Console.WriteLine("такого числа нет");
 else
 {
 object c = arr.GetValue(a,b);
 Console.WriteLine(c);
 }
