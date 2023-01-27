using mindbox;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace mindboxTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Triangle_Area_3and4and5_6returned() //Triangle unit test
        {
            double x = 3;
            double y = 5;
            double z = 4;
            IFigure q = new Triangle(x, z, y);

            Assert.That(q.Area(), Is.EqualTo(6));
        }

        [Test]
        public void Circle_Area_PI_31returned()
        {
            double x = Math.PI;
            IFigure w = new Circle(x);

            Assert.That(Math.Round(w.Area()), Is.EqualTo(31));
        }
    }
}