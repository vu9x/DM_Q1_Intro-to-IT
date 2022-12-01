// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double [,] Create2dArray() // Создание 2х мерного массива
{
    Console.Write("Input numbers of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input numbers of column: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    double[,] createdArray = new double[rows, columns];
    for(int i = 0; i < rows; i++){
        for(int j = 0; j < columns; j++){
            createdArray[i,j] = Math.Round(new Random().Next(minValue, maxValue+1) + new Random().NextDouble(), 2);
        }
    }
    return createdArray;
}

void ShowArray(double[,] array){

    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

ShowArray(Create2dArray());