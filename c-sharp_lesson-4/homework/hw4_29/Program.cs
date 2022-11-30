// Задача 29: Напишите программу, которая создает массив заданного пользователем размера, 
// заполняет массив элементами от 1 до 99 и выводит их на экран.

int [] CreateRandArray(int n){
    int [] arr = new int[n];
    for(int i = 0; i < n; i++){
        arr[i] = new Random().Next(1, 100);
    }
    return arr;
}

void PrintArray(int [] arr){

    Console.Write("[");
    for(int i = 0; i < arr.Length; i++){
        Console.Write($"{arr[i]}, ");
    }
    Console.Write("\b\b]");
}

Console.WriteLine("Input a lenght of your Array: ");
int num = Convert.ToInt32(Console.ReadLine());
PrintArray(CreateRandArray(num));