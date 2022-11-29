// Напишите программу, которая по заданнмоу номеру четверти,
// показывает диапозон возможных координат точек в этой четверти (х и y)

// int QuarterNumber = new Random.

// void Quaters(int quarter){

//     if(quarter == 1) Console.WriteLine("В первой четверти Х>0, Y>0");
//     else if(quarter == 2) Console.WriteLine("Во второй четверти X>0, Y<0");
//     else if(quarter == 3) Console.WriteLine("В третьей четверти X<0, Y<0");
//     else if(quarter == 4) Console.WriteLine("В четвертой четверти X<0, Y>0");
//     else Console.WriteLine("Такой четверти не существует");

// }

// Console.Write("Введите номер четверти: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Quaters(num);

//Напишите программу, которая принимает на вход координаты точки (X и Y),
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// void QuarterNumber(int x, int y){

//     if(x > 0 & y > 0) Console.WriteLine($"Первая четверть");
//     else if(x > 0 & y < 0) Console.WriteLine($"Вторая четверть");
//     else if(x < 0 & y < 0) Console.WriteLine($"Третья четверть");
//     else if(x < 0 & y > 0) Console.WriteLine($"Четвертая четверть");
//     else Console.WriteLine($"Нельзя найти номер четверти, x:{x} или y:{y} равно нулю");

// }

// Console.Write("Введите X: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите Y: ");
// int y = Convert.ToInt32(Console.ReadLine());
// QuarterNumber(x, y);

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

// void FindSquarePower(int number){
//     for(int i = 1; i <= number; i++){
//         double SquareNumber = Math.Pow(i, 2);
//         Console.Write(SquareNumber + ", ");
//     }
// }

// Console.Write("Введите число от 1 до 50: ");
// int x = Convert.ToInt32(Console.ReadLine());
// FindSquarePower(x);

// Напишите программу,
//которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве
//AB = √(xb - xa)^2 + (yb - ya)^2

// double DistanceXY(int xa, int ya, int xb, int yb){
//     double result = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2));
//     return result;
// }

// Console.Write("Введите координату X точки А: ");
// int xa = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату Y точки A: ");
// int ya = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату X точки B: ");
// int xb = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату Y точки B: ");
// int yb = Convert.ToInt32(Console.ReadLine());

// double answer = DistanceXY(xa, ya, xb, yb);
// Console.WriteLine($"Дистанция между точки А({xa};{ya}) и точки B({xb};{yb}) равна {answer}");
