/*  Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

double[,] arr = new double[3,3];
double[] b=new double[3];

Random random = new Random();
for (int m = 0; m < 3; m++)
{
    for (int n = 0; n < 3; n++)
    {arr[m, n] = random.Next(0,10); 
    Console.Write(arr[m,n] + " ");}
    Console.WriteLine();
}
            
for (int m=0,k=0;m<3;m++) 
    {
        double summa=0;
            for (int n=0;n<3;n++) 
                {summa+=arr[n,m];}
        b[k]=summa/3;
        Console.WriteLine("Среднее арифметическое столбца "+(m+1)+" равно: "+b[k]);
        k++;
    }           

