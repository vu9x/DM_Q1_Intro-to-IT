// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.

int ArithmeticProgression(int M, int N){
    if(M != N) return N + ArithmeticProgression(M, N-1);
    else return N;
}

Console.Write("Input M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input N: ");
int n = Convert.ToInt32(Console.ReadLine());

int number = ArithmeticProgression(m, n);
Console.WriteLine($"Arithmetic Progression between {m} and {n} = {number}");
