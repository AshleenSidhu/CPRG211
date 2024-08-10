using BasicMath;

namespace BasicMathTest
{
	[TestFixture]
	public class Tests
	{
		private BasicMath.BasicMath basicMath;

		[SetUp]
		public void Setup()
		{
			basicMath = new BasicMath.BasicMath();
		}

		[Test]
		public void Test_AddMethod()
		{
			double number1 = 4;
			double number2 = 9;
			double expected = 13;

			double result = basicMath.Add(number1, number2);
			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Test_SubtractMethod()
		{
			double number1 = 18;
			double number2 = 7;
			double expected = 11;

			double result = basicMath.Subtract(number1, number2);
			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Test_MultiplyMethod()
		{
			double number1 = 5;
			double number2 = 6;
			double expected = 30;

			double result = basicMath.Multiply(number1, number2);
			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Test_DivideMethod()
		{
			double number1 = 20;
			double number2 = 4;
			double expected = 5;

			double result = basicMath.Divide(number1, number2);
			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Test1()
		{
			//for dividing by zero
			double number1 = 20;
			double number2 = 0;

			Assert.Throws<DivideByZeroException>(() => basicMath.Divide(number1, 0));
		}
	}
}