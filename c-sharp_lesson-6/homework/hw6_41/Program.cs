// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int PositiveCounter(int N){
    int counter = 0;
    for(int i = 0; i < N; i++){
        Console.WriteLine($"Введите ваше {i+1} число массива: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if(number > 0) counter++;
    }
    return counter;
}

Console.WriteLine($"Введите размер массива массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int numbers = PositiveCounter(size);
Console.WriteLine($"Вы ввели {numbers} положительных чисел");
