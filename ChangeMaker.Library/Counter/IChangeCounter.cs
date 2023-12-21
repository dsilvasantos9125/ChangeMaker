namespace Change.Library;
public interface IChangeCounter {

	public static readonly decimal[] coinsType = [
		1m,
		0.5m,
		0.25m,
		0.1m,
		0.05m,
		0.01m
	];

	Dictionary<decimal, decimal> CalculateChange(decimal moneyAmount, decimal[] coinsType, int position = 0);
}
