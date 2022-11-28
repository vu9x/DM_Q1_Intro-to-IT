// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");
Console.Write("Input first int number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second int number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2){
    Console.WriteLine($"max = {num1}");
}
else{
    Console.WriteLine($"max = {num2}");
}

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
// (делится ли оно на два без остатка).
Console.WriteLine("Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).");
Console.Write("Input int number: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num % 2 == 0){
    Console.WriteLine($"{num} четное");
}
else{
    Console.WriteLine($"{num} нечетное");
}


// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");

Console.Write("Input int number: ");
int num_8 = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i <= num_8; i++){
    if(i%2 == 0){
        Console.Write(i + " ");
    }
}

