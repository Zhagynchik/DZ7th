/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет    */



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


Console.WriteLine("Введите позиции элемента");
 int x = Convert.ToInt32(Console.ReadLine());
 int y = Convert.ToInt32(Console.ReadLine());

if (x > array.GetLength(0)-1)
{
    Console.WriteLine("Такого числа в массиве нет");
}
else if (y> array.GetLength(1)-1)
{
    Console.WriteLine("Такого числа в массиве нет");
}

else
{
        object z = array.GetValue(x,y);
        Console.WriteLine($"Значение выбранного элемента массива {z}");
}


