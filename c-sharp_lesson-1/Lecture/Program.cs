/*
Console.Write("Input int number: ");

int num = Convert.ToInt32(Console.ReadLine());
int result = num * num;
Console.WriteLine($"Square number of {num} is {result}");



Console.Write("Input first int number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second int number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 == num2*num2){
    Console.WriteLine($"{num1} is a Square number of {num2}");
}
else{
    Console.WriteLine($"{num1} is not a Square number of {num2}");
}


// Задача 3. Напишите программу, которая на вход принимает число N, 
// а на выходе показывает число в промежутке от -N до N
Console.Write("Input int number: ");
int num = Convert.ToInt32(Console.ReadLine());
int current = (-1) * num;

// while(current <= num){
//     Console.Write(current + " ");
//     current++;
// }

for(int i = current; i <= num; i++){
    Console.Write(i + " ");
}
*/
// Задача 4. Напишите программу, которая принимает на вход трехзначное число
// и на выходе показывает последнюю цифру этого числа

Console.Write("Input Three-digits int number: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = num % 10;
Console.WriteLine($"Last digit of {num} is {result}");


