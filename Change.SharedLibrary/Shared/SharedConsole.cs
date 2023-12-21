namespace Change.SharedLibrary;

public class SharedConsole : ISharedConsole {
	public delegate string ReadMessage();
	public delegate void WriteMessage(string message);

	public string ReadLine()
		=> Console.ReadLine();

	public void WriteLine(string message)
		=> Console.WriteLine(message);

	public WriteMessage InstanceWriteDelegate() {
		WriteMessage writeMessage = WriteLine;

		return writeMessage;
	}
}
