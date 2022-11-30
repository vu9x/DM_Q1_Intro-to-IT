// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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

int EvenElements(int [] arr){
    int count = 0;
    for(int i = 0; i < arr.Length; i++){
        if(arr[i] % 2 == 0){
            count = count + 1;
        }
    }
    return count;
}

int [] MyArray = CreateNewArray(4);
Show(MyArray);
int EvenNumbers = EvenElements(MyArray);
Console.WriteLine($"Even numbers is {EvenNumbers}");

