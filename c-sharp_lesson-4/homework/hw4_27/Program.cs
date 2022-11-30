// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int SumOfDigits(int num)
{
    int count = 1;
    int CountNumb = num;

    for(int i = 1; i <= CountNumb; i++)
    {
        count++;
        CountNumb = CountNumb/10;
    }

    int result = 0;
    for(int i = 0; i < count; count--){
        result = result +  num / Convert.ToInt32(Math.Pow(10, count-1));
        num = num % Convert.ToInt32(Math.Pow(10, count-1));
    }

    return result;
}

int RandNum = new Random().Next(1, 100000);
int sum = SumOfDigits(RandNum);
Console.WriteLine($"Sum digit's number {RandNum} is {sum}");
