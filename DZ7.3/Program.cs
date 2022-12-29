/*Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.   */



Console.WriteLine("Введите размеры двумерного массива");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        
        array [i, j] = Convert.ToInt32(new Random().Next(0,10));  
        Console.Write($"{array[i, j]} ");
    }
        Console.WriteLine();
}

Console.Write($"Среднее арифметическое каждого столбца: ");

for (int i = 0; i < array.GetLength(1); i++)
{
    double summa = 0;
    double s = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        summa += array [j, i];
        s = Math.Round(summa/n, 2);
    }
    Console.Write($" {s} " );
}
