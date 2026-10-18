namespace EFT.Console.Core;

public class ConstructorFindResult
{
	public CommandItemBase Item; //Field offset: 0x10
	public string[] Arguments; //Field offset: 0x18
	public CommandFactory Factory; //Field offset: 0x20
	public Exception Exception; //Field offset: 0x28

	public ConstructorFindResult() { }

}

