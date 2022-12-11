//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.


int [,] Create2dArray() // Создание 2х мерного массива
{
    Console.Write("Input numbers of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input numbers of column: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] createdArray = new int[rows, columns];
    for(int i = 0; i < rows; i++){
        for(int j = 0; j < columns; j++){
            createdArray[i,j] = new Random().Next(minValue, maxValue+1);
        }
    }
    return createdArray;
}

void Show2dArray(int[,] array){

    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ShowRowIn2dArray(int[,] array, int row){
    for(int j = 0; j < array.GetLength(1); j++){
        Console.Write(array[row,j] + " ");
    }
}

void ShowArray(int[] array){
    for(int i = 0; i < array.Length; i++){
        Console.Write($" {i} = {array[i]};");
    }
}

void FindSmallestRowSum(int[,] array){
    int[] RowsSum = new int[array.GetLength(0)];
    for(int i = 0; i < array.GetLength(0); i++){
        int sum = 0;
        for(int j = 0; j < array.GetLength(1); j++){
            sum += array[i, j];
        }
        RowsSum[i] = sum;
    }
    
    int MinRow = 0;
    for(int i = 0; i < RowsSum.Length - 1; i++){
        if(RowsSum[i] < RowsSum[i+1]) MinRow = i;
        else MinRow = i+1;
    }

    Console.WriteLine($"Sum of 2d arrays is");
    ShowArray(RowsSum);

    Console.WriteLine($"Row with Min Sum is {MinRow}");
    ShowRowIn2dArray(array, MinRow);
}

int[,] myArray = Create2dArray();
Show2dArray(myArray);
FindSmallestRowSum(myArray);