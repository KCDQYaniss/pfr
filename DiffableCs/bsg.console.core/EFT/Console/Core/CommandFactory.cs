namespace EFT.Console.Core;

public sealed class CommandFactory
{
	[CompilerGenerated]
	private readonly CommandArgument[] <Arguments>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly AsyncCommandFactory <Factory>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <Documentation>k__BackingField; //Field offset: 0x20

	public CommandArgument[] Arguments
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public string Documentation
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public AsyncCommandFactory Factory
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public CommandFactory(CommandArgument[] arguments, AsyncCommandFactory factory) { }

	[CompilerGenerated]
	public CommandArgument[] get_Arguments() { }

	[CompilerGenerated]
	public string get_Documentation() { }

	[CompilerGenerated]
	public AsyncCommandFactory get_Factory() { }

	[CompilerGenerated]
	public void set_Documentation(string value) { }

}

