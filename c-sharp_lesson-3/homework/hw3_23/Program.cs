// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void FindCubePower(int number){
    for(int i = 1; i <= number; i++){
        double SquareNumber = Math.Pow(i, 3);
        Console.Write(SquareNumber + ", ");
    }
}

Console.Write("Введите число от 1 до 50: ");
int x = Convert.ToInt32(Console.ReadLine());
FindCubePower(x);