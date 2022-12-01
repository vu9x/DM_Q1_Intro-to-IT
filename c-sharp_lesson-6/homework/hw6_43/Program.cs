// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// k1 * x + b1 = k2 * x + b2
// x = (b2 - b1) / (k1 - k2)
// y = k2 * x + b2

double [] MeetingPoint(double k1, double b1, double k2, double b2){
    double [] Meet = new double[2];
    Meet[0] = (b2 - b1) / (k1 - k2);
    Meet[1] = k1 * Meet[0] + b1;
    return Meet;
}

void Show(double [] arr){

    Console.Write("{");
    for(int i = 0; i < arr.Length; i++){
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine("\b}");
}

Console.WriteLine($"Введите b1: ");
double B1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите k1: ");
double K1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите b2: ");
double B2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите k2: ");
double K2 = Convert.ToInt32(Console.ReadLine());

double[] ConnectPoint = MeetingPoint(K1, B1, K2, B2);
Show(ConnectPoint);