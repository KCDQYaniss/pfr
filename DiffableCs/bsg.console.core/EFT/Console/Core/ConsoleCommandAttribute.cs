namespace EFT.Console.Core;

[AttributeUsage(76)]
[MeansImplicitUse]
public sealed class ConsoleCommandAttribute : Attribute
{
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly string <Description>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly string <AwaitExecutionContext>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly string <ExecutionContext>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private readonly string[] <Aliases>k__BackingField; //Field offset: 0x30

	public string[] Aliases
	{
		[CompilerGenerated]
		 get { } //Length: 76
	}

	public string AwaitExecutionContext
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public string Description
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public string ExecutionContext
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public string Name
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public ConsoleCommandAttribute(string name, string executionContext = "", string awaitExecutionContext = null, string description = "", string[] aliases) { }

	[CompilerGenerated]
	public string[] get_Aliases() { }

	[CompilerGenerated]
	public string get_AwaitExecutionContext() { }

	[CompilerGenerated]
	public string get_Description() { }

	[CompilerGenerated]
	public string get_ExecutionContext() { }

	[CompilerGenerated]
	public string get_Name() { }

}

