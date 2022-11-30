// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным 
// и минимальным элементов массива.
// [3.0 7.2 22.7 2.1 78.3] -> 76.2

double[] CreateNewArray(int size){
    double [] arr = new double[size];
    for(int i = 0; i < size; i++){
        arr[i] = new Random().NextDouble() + new Random().Next(1, 10000);
    }
    return arr;
}

void Show(double [] arr){

    Console.Write("[");
    for(int i = 0; i < arr.Length; i++){
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine("\b]");
}

double DiffMaxMin(double[] arr){
    double min = arr[0];
    double max = 0;
    for(int i = 0; i < arr.Length; i++){
        if(min > arr[i]) min = arr[i];
        else if(arr[i] > max) max = arr[i];
    }
    return max-min;
}

double[] MyArray = CreateNewArray(4);
Show(MyArray);
double number = DiffMaxMin(MyArray);
Console.WriteLine($"Difference between max and min elemets is: {number}");
