// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.
//AB = √(xb - xa)^2 + (yb - ya)^2 + (zb - za)^2

double DistanceXYZ(int xa, int ya, int xb, int yb, int za, int zb){
    double result = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2)+ Math.Pow(zb - za, 2));
    return result;
}

Console.Write("Введите координату X точки А: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y точки A: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z точки A: ");
int za = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату X точки B: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y точки B: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z точки B: ");
int zb = Convert.ToInt32(Console.ReadLine());

double answer = DistanceXYZ(xa, ya, xb, yb, za, zb);
Console.WriteLine($"Дистанция между точки А({xa};{ya};{za}) и точки B({xb};{yb};{zb}) равна {answer}");
