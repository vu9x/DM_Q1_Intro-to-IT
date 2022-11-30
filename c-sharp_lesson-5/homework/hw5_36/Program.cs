// Задача 36: Задайте массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.

int [] CreateNewArray(int size){
    int [] arr = new int[size];
    for(int i = 0; i < size; i++){
        arr[i] = new Random().Next(1000, 10000);
    }
    return arr;
}

void Show(int [] arr){

    Console.Write("[");
    for(int i = 0; i < arr.Length; i++){
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine("\b]");
}

int OddIndexSum(int [] arr){
    int result = 0;
    for(int i = 0; i < arr.Length; i++){
        if(i % 2 != 0){
            result += arr[i];
        }
    }
    return result;
}

int [] MyArray = CreateNewArray(4);
Show(MyArray);
int OddSumIs = OddIndexSum(MyArray);
Console.WriteLine($"Odd index elements sum is {OddSumIs}");
