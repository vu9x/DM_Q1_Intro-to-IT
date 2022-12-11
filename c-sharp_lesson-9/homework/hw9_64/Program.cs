// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от N до 1. Выполнить с помощью рекурсии.

void NaturalFigures(int N){
    if(N > 0){
        Console.Write($"{N} ");
        NaturalFigures(N-1);
    }
}

Console.Write("Input natural number: ");
int number = Convert.ToInt32(Console.ReadLine());

NaturalFigures(number);
