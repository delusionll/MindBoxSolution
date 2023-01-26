using mindbox;

internal class Circle : IFigure
{
    private double Length { get; } //Radius
    public string Name { get; }

    public Circle(double radius)
    {
        Length = radius;
        Name = "Circle";
    }

    public double Area()
    {
        return Math.PI * Math.Pow(Length, 2);
    }
}