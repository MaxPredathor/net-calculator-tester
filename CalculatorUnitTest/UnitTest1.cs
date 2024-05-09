using net_calculator_tester;
namespace CalculatorUnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        // Per questo esercizio ho fatto generare dei test ad un IA chiedendogli di farli generici
        [Test]
        public void TestAdd()
        {
            Assert.AreEqual(5f, Calculator.Add(2f, 3f));
            Assert.AreEqual(-1f, Calculator.Add(-4f, 3f));
            Assert.AreEqual(0f, Calculator.Add(0f, 0f));
            Assert.AreEqual(1000f, Calculator.Add(500f, 500f));
            Assert.AreEqual(7.5f, Calculator.Add(3.5f, 4f));
        }
        [Test]
        public void TestSubtract()
        {
            Assert.AreEqual(1f, Calculator.Subtract(4f, 3f));
            Assert.AreEqual(-5f, Calculator.Subtract(-2f, 3f));
            Assert.AreEqual(0f, Calculator.Subtract(5f, 5f));
            Assert.AreEqual(2f, Calculator.Subtract(10f, 8f));
            Assert.AreEqual(1.5f, Calculator.Subtract(5f, 3.5f));
        }

        [Test]
        public void TestDivide()
        {
            Assert.AreEqual(2f, Calculator.Divide(6f, 3f));
            Assert.AreEqual(3f, Calculator.Divide(9f, 3f));
            Assert.AreEqual(-2f, Calculator.Divide(-6f, 3f));
            Assert.AreEqual(5f, Calculator.Divide(10f, 2f));
            Assert.AreEqual(1.25f, Calculator.Divide(5f, 4f));
        }

        [Test]
        public void TestMultiply()
        {
            Assert.AreEqual(6f, Calculator.Multiply(2f, 3f));
            Assert.AreEqual(-6f, Calculator.Multiply(-2f, 3f));
            Assert.AreEqual(0f, Calculator.Multiply(5f, 0f));
            Assert.AreEqual(100f, Calculator.Multiply(10f, 10f));
            Assert.AreEqual(15f, Calculator.Multiply(3f, 5f));
        }
    }
}