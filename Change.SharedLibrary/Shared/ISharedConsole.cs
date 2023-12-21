using static Change.SharedLibrary.SharedConsole;

namespace Change.SharedLibrary; 
public interface ISharedConsole {
	string ReadLine();
	void WriteLine(string message);
	public WriteMessage InstanceWriteDelegate();
}
