// See https://aka.ms/new-console-template for more information

using mindbox;

public class Triangle : IFigure
{
    private double Length { get; } //Сторона 1, основание???
    private double SecondSide { get; } //Сторона 2
    private double ThirdSide { get; } //Сторона 3
    public string Name { get; }

    public Triangle(double side1, double side2, double side3)
    {
        if (side1 <= 0 ^ side2 <= 0 ^ side3 <= 0)
        {
            throw new ArgumentException("Введите числа больше 0");
        }
        Length = side1;
        SecondSide = side2;
        ThirdSide = side3;
        Name = "Triangle";
        IsRight(); //Проверка на прямоугольность
    }

    public double Area()
    {
        double p = (Length + SecondSide + ThirdSide) / 2;
        return Math.Sqrt(p * (p - Length) * (p - SecondSide) * (p - ThirdSide));
    }

    private bool IsRight() //Ответственность только этого класса
    {
        if (Area() == 0.5 * Length * SecondSide ^ Area() == 0.5 * Length * ThirdSide ^ Area() == 0.5 * SecondSide * ThirdSide)
        {
            //Console.WriteLine("Треугольник прямоугольный");
            return true;
        }
        else { return false; }
    }
}