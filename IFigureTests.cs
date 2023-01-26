using mindbox;

namespace mindboxTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Area_3and4and5_6returned()
        {
            double x = 3;
            double y = 5;
            double z = 4;
            IFigure q = new Triangle(x, z, y);

            Assert.That(q.Area(), Is.EqualTo(6));
        }
    }
}