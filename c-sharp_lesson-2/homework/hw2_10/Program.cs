// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе 
// показывает вторую цифру этого числа.

int FindSecondDigit(int number)
{
    int result = number % 100 / 10;
    return result;
}

int RandNumb = new Random().Next(100,1000);
int SecondDigit = FindSecondDigit(RandNumb);

Console.WriteLine($"Second digit of number {RandNumb} is {SecondDigit}");
