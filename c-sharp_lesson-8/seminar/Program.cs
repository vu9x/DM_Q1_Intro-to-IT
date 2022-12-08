// Задайте двумерный массив. Напишите программу, которая поменяет местами две любые строки массива.

// int [,] Create2dArray(int rows, int columns, int minValue, int maxValue) // Создание 2х мерного массива
// {
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

// int[,] ChangeRows(int[,] array, int row1, int row2)
// {
//     if(row1 >= 0 && row1 < array.GetLength(0) && row2 >=0 && row2 < array.GetLength(0) && row1 != row2)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             int temp = array[row1,j];
//             array[row1, j] = array[row2, j];
//             array[row2, j] = temp;
//         }
//     }
//     else Console.WriteLine("incorrect input");

//     return array;
// }

// Console.Write("Input numbers of rows: ");
// int row = Convert.ToInt32(Console.ReadLine()); // кол-во строк
// Console.Write("Input numbers of column: ");
// int column = Convert.ToInt32(Console.ReadLine()); //  кол-во столбцов
// Console.Write("Input min value: ");
// int min = Convert.ToInt32(Console.ReadLine()); // мин значение
// Console.Write("Input max value: ");
// int max = Convert.ToInt32(Console.ReadLine()); // макс значение

// Console.Write("Input number of 1st row to move: ");
// int user_row1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number of 2nd row to move: ");
// int user_row2 = Convert.ToInt32(Console.ReadLine());

// int[,] newArray = Create2dArray(row, column, min, max);
// ShowArray(newArray);

// ShowArray(ChangeRows(newArray, user_row1, user_row2));

// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
//В случае, если это невозможно, программа должна вывести сообщение для пользователя.


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

// void MatrixChange(int[,] array)
// {
//     if(array.GetLength(0) != array.GetLength(1))
//     {
//         Console.WriteLine("Let it be square matrix");
//     }
//     else{
//         for(int i = 0; i < array.GetLength(0); i++){
//             for(int j = i; j < array.GetLength(1); j++){
//                 int temp = array[i,j];
//                 array[i, j] = array[j,i];
//                 array[j, i] = temp;
//             }
//         }
//     }
// }

// int[,] initMatrix = Create2dArray();
// ShowArray(initMatrix);
// MatrixChange(initMatrix);
// ShowArray(initMatrix);


// Задайте двумерный массив из целых чисел. Напишите программу, которая обнулит строку и столбец, 
// на пересечении которых расположен первый наименьший элемент массива.


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

int[,] ChangeRowColumn(int[,] array2d){
    int iMin = 0;
    int jMin = 0;
    for(int i = 0; i < array2d.GetLength(0); i++)
    {
        for(int j = 0; j < array2d.GetLength(1); j++){
            if(array2d[i, j] < array2d[iMin, jMin])
            {
                iMin = i;
                jMin = j;
            }
        }
    }
    Console.WriteLine($"{iMin}, {jMin} = {array2d[iMin, jMin]}");
    for(int i = 0; i < array2d.GetLength(0); i++)
    {
        for(int j = 0; j < array2d.GetLength(1); j++){
            if(i == iMin || j == jMin)
            {
                array2d[i, j] = 0;
            }
        }
    }
    return array2d;
}

int[,] myArray = Create2dArray();
ShowArray(myArray);
ChangeRowColumn(myArray);
ShowArray(myArray);
