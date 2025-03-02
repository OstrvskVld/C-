using System;

class Program
{
    static string CheckPoint(double x, double y, double a, double b, double R)
    {
        bool inRectangle = x >= -a && x <= a && y >= -b && y <= b;
        bool inCircle = x * x + y * y <= R * R;

        bool onRectangleBorder = (x == -a || x == a) && y >= -b && y <= b ||
                                 (y == -b || y == b) && x >= -a && x <= a;

        bool onCircleBorder = Math.Abs(x * x + y * y - R * R) < 1e-6; 

        if (onRectangleBorder || onCircleBorder)
            return "На межі";
        else if (inRectangle && !inCircle)
            return "Так";
        else
            return "Ні";
    }

    static void Main()
    {
        Console.Write("Введіть x: ");
        double x = double.Parse(Console.ReadLine() ?? "0");

        Console.Write("Введіть y: ");
        double y = double.Parse(Console.ReadLine() ?? "0");

        Console.Write("Введіть a: ");
        double a = double.Parse(Console.ReadLine() ?? "0");

        Console.Write("Введіть b: ");
        double b = double.Parse(Console.ReadLine() ?? "0");

        Console.Write("Введіть R: ");
        double R = double.Parse(Console.ReadLine() ?? "0");

        string result = CheckPoint(x, y, a, b, R);
        Console.WriteLine(result);
    }
}
