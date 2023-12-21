namespace Change.Manager; 
public interface IAppManager {
	void Run();
	void WriteWelcomeMessage();
	void WriteAmount();
	void WriteMessage(Dictionary<decimal, decimal> totalChange);
	decimal ReadAmount();
}
