/* Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/




double[,] arr = new double[3, 4];

Random random = new Random();
for (int m = 0; m < 3; m++)
{
    for (int n = 0; n < 4; n++)
    {
        arr[m, n] = random.NextDouble() * 10; 
        Console.Write("{0,6:F1}", arr[m, n]);
    }
    Console.WriteLine();
} 

