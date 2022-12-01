// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

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

bool InArrayOrNot(int[,] array){

    Console.Write("Input i index: ");
    int i = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input j index: ");
    int j = Convert.ToInt32(Console.ReadLine());

    if(i <= array.GetLength(0) && j <= array.GetLength(1)){
        Console.WriteLine($"Element array({i},{j}) = {array[i,j]}");
        return true;
    }
    else{
        Console.WriteLine($"Element array({i},{j}) is not exist");
        return false;
    }
}

int[,] MyArray = Create2dArray();
ShowArray(MyArray);
InArrayOrNot(MyArray);
