//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.

int DayOfWeek = new Random().Next(1,7);

bool Weekend(int a){
    if(a >=6) return true;
    else return false;
}
if(Weekend(DayOfWeek)) Console.WriteLine($"Day {DayOfWeek} is a weekend");
else Console.WriteLine($"Day {DayOfWeek} is not a weekend");