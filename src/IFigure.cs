namespace mindbox
{
    public interface IFigure //Интерфейс для классов с похожей функциональностью
    {
        public double Area(); //Необходимый метод нахождения площади фигур

        public string Name { get; } // Свойство название фигуры
    }
}