using Change.Library;

namespace Change.Test.Counter;
public class ChangeCounterTest {

	private ChangeCounter context;

	[SetUp]
	public void Setup() {
		context = new ChangeCounter();
	}

	[Test]
	public void CalculateChange_ShouldReturnResult() {
		//Arrange
		decimal expectedMoneyAmount = 10.25m;

		decimal[] coinsType = [
			1m,
			0.5m,
			0.25m,
			0.1m,
			0.05m,
			0.01m
		];

		Dictionary<decimal, decimal> expectedResult = new() {
			{ 1m, 10m },
			{ 0.5m, 0m },
			{ 0.25m, 1m },
			{ 0.1m, 0m },
			{ 0.05m, 0m },
			{ 0.01m, 0m }
		};

		//Act
		Dictionary<decimal, decimal> result = context.CalculateChange(
			expectedMoneyAmount, coinsType
			);

		//Assert
		Assert.That(result, Is.EqualTo(expectedResult), "Expected result");
	}
}
