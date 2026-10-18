namespace EFT.Console.Core;

public class NoopCommand : SyncCommand, ICustomPrintCommand
{

	public virtual object[] ArgumentsValue
	{
		 get { } //Length: 53
	}

	public NoopCommand() { }

	public virtual void Execute() { }

	public virtual object[] get_ArgumentsValue() { }

	public override string PrintCommand() { }

}

