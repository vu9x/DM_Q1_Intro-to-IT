//Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

// int [,] Create2dArray() // Создание 2х мерного массива
// {
//     Console.Write("Input numbers of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input numbers of column: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input min value: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input max value: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     int[,] createdArray = new int[rows, columns];
//     for(int i = 0; i < rows; i++){
//         for(int j = 0; j < columns; j++){
//             createdArray[i,j] = new Random().Next(minValue, maxValue+1);
//         }
//     }
//     return createdArray;
// }

// void ShowArray(int[,] array){

//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// ShowArray(Create2dArray());

// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// int [,] Create2dArray() // Создание 2х мерного массива
// {
//     Console.Write("Input numbers of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input numbers of column: ");
//     int columns = Convert.ToInt32(Console.ReadLine());

//     int[,] createdArray = new int[rows, columns];
//     for(int i = 0; i < rows; i++){
//         for(int j = 0; j < columns; j++){
//             createdArray[i,j] = i + j;
//         }
//     }
//     return createdArray;
// }

// void ShowArray(int[,] array){

//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// ShowArray(Create2dArray());

// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.

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

int [,] ChangedArray(int[,] arr) // Создание 2х мерного массива
{
    int[,] NewArray = new int[arr.GetLength(0), arr.GetLength(1)];
    for(int i = 0; i < arr.GetLength(0); i++){
        for(int j = 0; j < arr.GetLength(1); j++){
            if(i % 2 == 0 && j % 2 == 0){
                NewArray[i,j] = arr[i,j] * arr[i,j];
            }
            else NewArray[i,j] = arr[i,j];
        }
    }
    return NewArray;
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

int[,] CurrentArray = Create2dArray();
int[,] SecondArray = ChangedArray(CurrentArray);
ShowArray(CurrentArray);
ShowArray(SecondArray);
