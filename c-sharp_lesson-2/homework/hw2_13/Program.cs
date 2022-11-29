// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

bool IsThirdExist(int num)
{
    if(num >= 100) return true;
    else return false;
}
// int FindThirdDigit(int num)
// {

// }

int NumberOfDigits(int num)
{
    int count = 0;
    while(num != 0){
        num = num / 10;
        count++;
    }
    return count;
}

int FindThirdDigit(int num, int count){
    int differ = Convert.ToInt32(Math.Pow(10, count-3));
    int result = num / differ % 10;
    return result;
}

int number = new Random().Next(1, 10000000);
int power_new = NumberOfDigits(number);

if(power_new >= 3){
    int a = FindThirdDigit(number, power_new);
    Console.WriteLine($"Third digit of number {number} is {a}");
}
else Console.WriteLine($"Your Number {number} is lower than 3 digits");
