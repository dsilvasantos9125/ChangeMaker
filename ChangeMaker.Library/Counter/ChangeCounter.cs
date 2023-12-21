namespace Change.Library;
public class ChangeCounter : IChangeCounter {
	public Dictionary<decimal, decimal> CalculateChange(decimal moneyAmount, decimal[] coinsType, int position = 0) {

		if (position >= coinsType.Length) return [];

		decimal currentCoin = coinsType[position];

		decimal totalCoins = Math.Floor(moneyAmount / currentCoin);

		decimal remainder = moneyAmount - totalCoins * currentCoin;

		Dictionary<decimal, decimal> result = CalculateChange(remainder, coinsType, position + 1);

		result.Add(currentCoin, totalCoins);

		return result;
	}
}
