// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void Main()
{
    double b1 = GetNumber();
    double k1 = GetNumber();
    double b2 = GetNumber();
    double k2 = GetNumber();
    double x = ResultX(b1, k1, b2, k2);
    double y = ResultY(b1, k1, x);
    Console.WriteLine($"Точка пересечения двух прямых -> ({x}; {y})");
}

double GetNumber()
{
    Console.WriteLine("Введите число: ");
    double number = double.Parse(Console.ReadLine());
    return number;
}

double ResultX(double a1, double c1, double a2, double c2)
{
    double res = -(a1 - a2) / (c1 - c2);
    res = Math.Round(res, 3);
    return res;
}

double ResultY(double b, double k, double n)
{
    double res2 = k * n + b;
    res2 = Math.Round(res2, 3);
    return res2;
}
Main();
