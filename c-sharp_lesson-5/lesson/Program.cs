// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма отрицательных равна -20.

// int [] CreateNewArray(int size, int minVal, int maxVal){
//     int [] arr = new int[size];
//     for(int i = 0; i < size; i++){
//         arr[i] = new Random().Next(minVal, maxVal + 1);
//     }
//     return arr;
// }

// void Show(int [] arr){

//     Console.Write("[");
//     for(int i = 0; i < arr.Length; i++){
//         Console.Write(arr[i] + " ");
//     }
//     Console.WriteLine("\b\b]");
// }

// int SumNegative(int [] arr){
//     int result = 0;
//     for(int i = 0; i < arr.Length; i++){
//         if(arr[i] < 0) result +=arr[i];
//     }
//     return result;
// }

// Console.WriteLine("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение массива: ");
// int minVal = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение массива: ");
// int maxVal = Convert.ToInt32(Console.ReadLine());

// int [] newArray = CreateNewArray(size, minVal, maxVal);
// Show(newArray);
// int Negative = SumNegative(newArray);

// Console.WriteLine($"Sum of negative elements inside array is {Negative}");

// Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные,
//и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]

// int [] CreateNewArray(int size, int minVal, int maxVal){
//     int [] arr = new int[size];
//     for(int i = 0; i < size; i++){
//         arr[i] = new Random().Next(minVal, maxVal + 1);
//     }
//     return arr;
// }

// void Show(int [] arr){

//     Console.Write("[");
//     for(int i = 0; i < arr.Length; i++){
//         Console.Write(arr[i] + " ");
//     }
//     Console.WriteLine("\b\b]");
// }

// int [] MirrorArray(int [] arr){
//     int [] result = new int[arr.Length];
//     for(int i = 0; i < arr.Length; i++){
//         result[i] = arr[i] * (-1);
//     }
//     return result;
// }

// int size = 12;
// int minVal = -9;
// int maxVal = 9;

// int [] initialArray = CreateNewArray(size, minVal, maxVal);
// Show(initialArray);
// int [] newArray = MirrorArray(initialArray);
// Show(newArray);


//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//-3; массив [6, 7, 19, 345, 3] -> да

// int [] CreateNewArray(int size, int minVal, int maxVal){
//     int [] arr = new int[size];
//     for(int i = 0; i < size; i++){
//         arr[i] = new Random().Next(minVal, maxVal + 1);
//     }
//     return arr;
// }

// void Show(int [] arr){

//     Console.Write("[");
//     for(int i = 0; i < arr.Length; i++){
//         Console.Write(arr[i] + " ");
//     }
//     Console.WriteLine("\b\b]");
// }

// bool FindElement(int num, int [] array){
//     for(int i = 0; i < array.Length; i++){
//         if(array[i] == num){
//             return true;
//         }
//     }
//     return false;
// }

// Console.WriteLine("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение массива: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение массива: ");
// int max = Convert.ToInt32(Console.ReadLine());


// int [] ourArray = CreateNewArray(size, min, max);
// Show(ourArray);

// Console.WriteLine("Проверочное число: ");
// int checkNumber = Convert.ToInt32(Console.ReadLine());
// if(FindElement(checkNumber, ourArray)){
//     Console.WriteLine($"Число {checkNumber} есть в массиве");
// }
// else{
//     Console.WriteLine($"Число {checkNumber} нет в массиве");
// }

//Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int [] CreateNewArray(int size, int minVal, int maxVal){
    int [] arr = new int[size];
    for(int i = 0; i < size; i++){
        arr[i] = new Random().Next(minVal, maxVal + 1);
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

int ArraySize(int [] arr){
    int size_end =  0;
    if(arr.Length % 2 == 0){
        size_end = arr.Length / 2;
    }
    else{
        size_end = arr.Length / 2 + 1;
    }
    return size_end;
}

int [] Multi(int [] array){
    int NewArraySize = ArraySize(array);
    int [] NewArray = new int[NewArraySize];
    for (int i = 0; i < NewArray.Length; i++){
        if(i == array.Length - 1 - i){
            NewArray[i] = array[i];
        }
        else{
            NewArray[i] = array[i] * array[array.Length-1 - i];
        }
    }
    return NewArray;
}

int [] CurrentArray = CreateNewArray(5, 1, 5);
Show(CurrentArray);

int [] MyArray = Multi(CurrentArray);
Show(MyArray);