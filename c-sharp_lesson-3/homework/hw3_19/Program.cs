//Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.

bool Palindrom(int number){
    int first_num = number / 10000;
    int second_num = number / 1000 % 10;
    int fourth_num = number % 100 / 10;
    int fifth_num = number % 10;
    if(first_num == fifth_num & second_num == fourth_num) return true;
    else return false;
}

Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num > 9999 & num < 100000){
    if(Palindrom(num)) Console.WriteLine($"Введеное число {num} является палиндромом");
    else Console.WriteLine($"Введеное число {num} не является палиндромом");
}
else Console.WriteLine($"Введеное число {num} не является пятизначным");
