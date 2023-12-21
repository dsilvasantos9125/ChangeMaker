using Change.Library;

namespace Change.Manager;
public class AppManager : IAppManager {
	private readonly IChangeCounter _changeCounter;

	public AppManager(
		IChangeCounter changeCounter
		) {
		_changeCounter = changeCounter;
	}

	public void Run() {
		WriteWelcomeMessage();
		WriteAmount();

		decimal moneyAmount = ReadAmount();

		Dictionary<decimal, decimal> totalChange = _changeCounter.CalculateChange(
			moneyAmount, IChangeCounter.coinsType
			);
		totalChange = totalChange.OrderByDescending(x => x.Key).ToDictionary();

		WriteMessage(totalChange);
	}

	#region
	public decimal ReadAmount()
	=> decimal.Parse(Console.ReadLine() ?? "0");

	public void WriteAmount()
		=> Console.WriteLine("Write the money amount:");

	public void WriteMessage(Dictionary<decimal, decimal> totalChange) {
		Dictionary<decimal, string> coinsNames = new() {
			{ 1m, "Dollar" },
			{ 0.5m, "Half" },
			{ 0.25m, "Quarter" },
			{ 0.1m, "Dime" },
			{ 0.05m, "Nickel" },
			{ 0.01m, "Penny" }
		};

		foreach (KeyValuePair<decimal, decimal> coinAmount in totalChange) {
			string coinName = coinsNames[coinAmount.Key];
			decimal coinValue = coinAmount.Value;

			Console.WriteLine($"{coinName}: {coinValue}");
		}
	}

	public void WriteWelcomeMessage()
		=> Console.WriteLine("Change Maker - Calculate Change");

	#endregion
}
