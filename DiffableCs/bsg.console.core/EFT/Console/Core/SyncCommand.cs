namespace EFT.Console.Core;

public abstract class SyncCommand : IConsoleCommand
{
	protected ConsoleProcessor _processor; //Field offset: 0x10

	public abstract object[] ArgumentsValue
	{
		 get { } //Length: 0
	}

	protected SyncCommand() { }

	public override void Execute(ConsoleProcessor processor, Action onComplete) { }

	public abstract void Execute() { }

	public abstract object[] get_ArgumentsValue() { }

}

