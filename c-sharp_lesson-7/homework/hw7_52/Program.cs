// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

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
            createdArray[i,j] = new Random().Next(minValue, maxValue+1);
        }
    }
    return createdArray;
}

void Show2dArray(double[,] array){

    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Show(double [] arr){

    Console.Write("{");
    for(int i = 0; i < arr.Length; i++){
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine("\b}");
}

double[] ColumnAverage(double[,] array){
    double[] result = new double[array.GetLength(1)];

    for(int j = 0; j < array.GetLength(1); j++){
        double num = 0;
        for(int i = 0; i < array.GetLength(0); i++){
            num += array[i,j];
        }
        result[j] = Math.Round(num / array.GetLength(0),1);
    }
    return result;
}

double[,] My2dArray = Create2dArray();
Show2dArray(My2dArray);
double[] MyAverage = ColumnAverage(My2dArray);
Show(MyAverage);
