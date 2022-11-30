// Задача 25: Напишите программу, которая принимает на вход два числа (A и B) и возводит число A 
//в натуральную степень B (Math.Pow НЕ использовать)

int Pow(int number, int power){
    int result = 1;
    for(int i = 1; i <= power; i++){
        result *= number;
    }
    return result;
}

Console.WriteLine("Input your number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input power: ");
int power = Convert.ToInt32(Console.ReadLine());

int NewNumber = Pow(num, power);

Console.WriteLine($"{num}^{power} = {NewNumber}");