// Напишите программу, которая принадлежит число (А) и выдает сумму числе от 1 до А
// int FindSum(int a){
//     int number = 0;
//     for(int i = 1; i<= a; i++){
//         number += i;
//     }
//     return number;
// }

// int RandNumb = new Random().Next(1, 100);
// int NewNumber = FindSum(RandNumb);
// Console.WriteLine($"Sum from 1 to {RandNumb} is {NewNumber}");


// Напишите программу, которая находит в последовательности от 1 до N все нечетные числа
// void FindOddNum(int n){
//     for(int curr = 1; curr <= n; curr += 2){
//         Console.Write($"{curr}, ");
//     }
// }

// Console.WriteLine("Input positive integer number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if(num > 1){
//     FindOddNum(num);
// }
// else{
//     Console.WriteLine("Please add Positive number");
// }

// Напишите программу, которая принимает на вход число N и выдает произведение числе от 1 до N
// int FindFactorial(int n){
//     int result = 1;
//     for(int curr = 1; curr <= n; curr++){
//         result *= curr;
//     }
//     return result;
// }

// Console.WriteLine("Input natural integers number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if(num == 0){
//     Console.WriteLine($"Factorial {num} is 1");
// }
// else if(num > 0){
//     int Factorial = FindFactorial(num);
//     Console.WriteLine($"Factorial of number {num} is {Factorial}");
// }
// else {
//     Console.WriteLine("Please add natural number");
// }

// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3

// int NumberOfDigits(int num)
// {
//     int count = 0;
//     while(num != 0){
//         num = num / 10;
//         count++;
//     }
//     return count;
// }

// int RandNumb = new Random().Next(1, 10000);
// int Digits = NumberOfDigits(RandNumb);
// Console.WriteLine($"Number of digits in {RandNumb} is {Digits}");

//Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int [] CreateRandArray(int n){
//     int [] arr = new int[n];
//     for(int i = 0; i < n; i++){
//         arr[i] = new Random().Next(0,2);
//     }
//     return arr;
// }

// void PrintArray(int [] arr){

//     Console.Write("[");
//     for(int i = 0; i < arr.Length; i++){
//         Console.Write($"{arr[i]}, ");
//     }
//     Console.Write("\b\b]");
// }

// PrintArray(CreateRandArray(8));