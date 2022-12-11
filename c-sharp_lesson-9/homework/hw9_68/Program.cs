// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int Ackermann(int M, int N){
    if (M == 0) return N + 1;
    else{
        if ((M != 0) && (N == 0)) return Ackermann(M - 1, 1);
        else return Ackermann(M - 1, Ackermann(M, N - 1));
    }
}

Console.Write("Input M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input N: ");
int n = Convert.ToInt32(Console.ReadLine());

int A = Ackermann(m, n);
Console.WriteLine($"A({m}, {n}) = {A}");