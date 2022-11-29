/*
// задача 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.

int FindBiggestDigit (int RandomNumber)
{
    int ed = RandomNumber % 10;     // единицы
    int dec = RandomNumber / 10;      // десятки
    
    if(ed > dec) return ed;
    else return dec;
}

int RandNumber = new Random().Next(10,100);
int BiggestDigit =  FindBiggestDigit(RandNumber);
Console.WriteLine($"The biggest digit of {RandNumber} is {BiggestDigit}");


// задача. Напишите программу, которая выводит случайное число и удаляет вторую цифру этого числа.

int DeleteSecondDigit(int num)
{
    int digit1 = num / 100;            // found the  hundred's digit (354 -> 3)
    int digit3 = num % 10;             // found the number (354 -> 4)
    int result = digit1 * 10 + digit3; // combining the hundred and number (354 -> 34)
    return result;
}
int RandNumber = new Random().Next(100,1000);
int TwoDigit = DeleteSecondDigit(RandNumber);
Console.WriteLine($"Result of converting {RandNumber} is {TwoDigit}");

// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно a и b.
void CheckDifference(int num1, int num2, int num3)
{
    int result;
    if(num2 % num1 == 0 & num3 % num1 ==0)
    {
        Console.WriteLine($"{num1} is multiply {num2} and {num2}");
    }
    else
    {
        Console.WriteLine($"{num1} is not multiply {num2} and {num2}");
    }
}

int RandNum1 = new Random().Next(1,10);
int RandNum2 = new Random().Next(10,100);
int RandNum3 = new Random().Next(10,100);

int result3 = CheckDifference(RandNum1, RandNum2, RandNum3);
Console.WriteLine($"Проверяем кратность числа {RandNum2} к числу {RandNum1}. Результат: {result3}.  0 - кратно, остальные числа - остаток от деления");
*/

// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

bool IsSquareNumber(int num1, int num2)
{
    if(num1 == num2 * num2 || num2 == num1 * num1) return true;
    else return false;
}

Console.WriteLine("Input first numer: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second numer: ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool result = IsSquareNumber(num1, num2);
if(result)
{
    Console.WriteLine("One of the number is square");
}
else{
    Console.WriteLine("No number is square");
}
