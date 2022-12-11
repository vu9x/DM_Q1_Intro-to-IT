// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.

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

void ShowArray(int[,] array){

    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void orderTheArray(int[,] array, int row, int column){
    if(column > 0) {
        int temp = array[row, column];
        if(array[row, column] > array[row, column-1]){
            array[row, column] = array[row, column-1];
            array[row, column-1] = temp;
        }
        orderTheArray(array, row, column-1);
    }
}

int[,] myArray = Create2dArray();
ShowArray(myArray);

for(int i = 0; i < myArray.GetLength(0); i++){
    for(int j = 0; j < myArray.GetLength(1); j++){
        orderTheArray(myArray, i, j);
    }
}
ShowArray(myArray);

