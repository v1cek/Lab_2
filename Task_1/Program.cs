using System;

class Rectangle
{
    private double side1;
    private double side2;

    public Rectangle(double side1, double side2)
    {
        this.side1 = side1;
        this.side2 = side2;
    }

    public double CalculateArea()
    {
        return side1 * side2;
    }

    public double CalculatePerimeter()
    {
        return 2 * (side1 + side2);
    }

    public double Area
    {
        get { return CalculateArea(); }
    }

    public double Perimeter
    {
        get { return CalculatePerimeter(); }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введіть довжину першої сторони: ");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть довжину другої сторони: ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Rectangle rect = new Rectangle(side1, side2);

        Console.WriteLine("Периметр: " + rect.Perimeter);
        Console.WriteLine("Площа: " + rect.Area);
    }
}
