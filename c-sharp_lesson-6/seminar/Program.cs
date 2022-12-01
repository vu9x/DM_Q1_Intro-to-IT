// развертите массив

// int[] CreateNewArray(int size, int minVal, int maxVal){
//     int [] arr = new int[size];
//     for(int i = 0; i < size; i++){
//         arr[i] = new Random().Next(minVal, maxVal+1);
//     }
//     return arr;
// }

// void Show(int [] arr){

//     Console.Write("[");
//     for(int i = 0; i < arr.Length; i++){
//         Console.Write(arr[i] + " ");
//     }
//     Console.WriteLine("\b]");
// }

// int [] ReversedArray(int [] arr){
//     int k = arr.Length;
//     for(int i = 0; i < k / 2; i++){
//         int temp = arr[i];
//         arr[i] = arr[k-1-i];
//         arr[k-1-i] = temp;
//     }
//     return arr;
// }

// Console.WriteLine("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение массива: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение массива: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int [] newArray = CreateNewArray(size, min, max);
// Show(newArray);
// Show(ReversedArray(newArray));

// Преобрзовать десятичное число в двоичное

// string BinaryConvert(int num){
//     string result = string.Empty;
//     while(num !=0){
//         result = num % 2 + result;
//         num = num / 2;
//     }
//     return result;
// }

// Console.WriteLine("Введите 10тичное число: ");
// int number10 = Convert.ToInt32(Console.ReadLine());

// string res = BinaryConvert(number10);
// Console.WriteLine($"Десятичное число: {number10}, его двоичная версия {res}");

// Не используя рекурсию, выведите N число фибоначчи, первые 2 числа a и b вводит пользователь

// void Fibonachi(int amount, int first, int second){
//     int [] arr = new int[amount];
//     arr[0] = first;
//     arr[1] = second;
//     for(int i = 2; i < amount; i++){
//         arr[i] = arr[i - 1] + arr[i - 2];
//     }
//     Show(arr);
// }

// void Show(int [] arr){

//     Console.Write("[");
//     for(int i = 0; i < arr.Length; i++){
//         Console.Write(arr[i] + " ");
//     }
//     Console.WriteLine("\b]");
// }

// Console.WriteLine("Введите размер массива: ");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите первое число Фибоначчи: ");
// int n1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число Фибоначчи: ");
// int n2 = Convert.ToInt32(Console.ReadLine());

// Fibonachi(N, n1, n2);

// Напишите программу, принимаему 3 числа. Она проверит можно ли получить треугольник

// void Triangle(int a, int b, int c){
//     if(a < b + c && b < a + c && c < b + a){
//         Console.WriteLine($"Треугольник с {a}, {b}, {c} существует.");
//     }
//     else{
//         Console.WriteLine($"Треугольник с {a}, {b}, {c} не существует.");
//     }
// }


// Console.WriteLine("Введите размер первой стророны: ");
// int n1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите размер второй стророны: ");
// int n2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите размер третьей стророны: ");
// int n3 = Convert.ToInt32(Console.ReadLine());

// Triangle(n1, n2, n3);

