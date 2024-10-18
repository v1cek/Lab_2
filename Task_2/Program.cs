using System;

class Point
{
    private double x;
    private double y;
    private string name;

    public Point(double x, double y, string name)
    {
        this.x = x;
        this.y = y;
        this.name = name;
    }

    public double X
    {
        get { return x; }
    }

    public double Y
    {
        get { return y; }
    }

    public string Name
    {
        get { return name; }
    }
}

class Figure
{
    private Point[] points;

    public Figure(Point[] points)
    {
        this.points = points;
    }

    public double GetSideLength(Point A, Point B)
    {
        return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
    }

    public void CalculatePerimeter()
    {
        double perimeter = 0;

        for (int i = 0; i < points.Length - 1; i++)
        {
            perimeter += GetSideLength(points[i], points[i + 1]);
        }

        perimeter += GetSideLength(points[points.Length - 1], points[0]); // Додаємо сторону між останньою та першою точкою

        Console.WriteLine("Периметр: " + perimeter);
    }

    public string GetName()
    {
        switch (points.Length)
        {
            case 3:
                return "Трикутник";
            case 4:
                return "Чотирикутник";
            case 5:
                return "П'ятикутник";
            default:
                return "Багатокутник";
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введіть кількість точок (3-5): ");
        int pointCount = Convert.ToInt32(Console.ReadLine());

        if (pointCount < 3 || pointCount > 5)
        {
            Console.WriteLine("Невірна кількість точок! Програма підтримує від 3 до 5 точок.");
            return;
        }

        Point[] points = new Point[pointCount];

        for (int i = 0; i < pointCount; i++)
        {
            Console.WriteLine($"Введіть координати точки {i + 1}:");
            Console.Write("X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.Write($"Введіть ім'я точки {i + 1} (наприклад, A): ");
            string name = Console.ReadLine();

            points[i] = new Point(x, y, name);
        }

        Figure figure = new Figure(points);

        Console.WriteLine("Назва фігури: " + figure.GetName());
        figure.CalculatePerimeter();
    }
}
