using mindbox;

internal class Circle : IFigure
{
    private double Length { get; } //Здесь как Радиус круга
    public string Name { get; }

    public Circle(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("Введите число больше 0");
        }
        Length = radius;
        Name = "Circle";
    }

    public double Area()
    {
        return Math.PI * Math.Pow(Length, 2);
    }
}