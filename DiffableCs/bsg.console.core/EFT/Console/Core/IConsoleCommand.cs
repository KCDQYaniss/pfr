namespace EFT.Console.Core;

public interface IConsoleCommand
{

	public object[] ArgumentsValue
	{
		 get { } //Length: 0
	}

	public void Execute(ConsoleProcessor processor, Action onComplete) { }

	public object[] get_ArgumentsValue() { }

}

