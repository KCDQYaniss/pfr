namespace EFT.Console.Core;

public class CommandItemInfo : CommandItemBase
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public string[] argumentList; //Field offset: 0x10

		public <>c__DisplayClass10_0() { }

		internal bool <FindConstructor>b__0(CommandFactory el) { }

	}

	[CompilerGenerated]
	private readonly CommandFactory[] <Constructors>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private readonly string <ExecutionContext>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private readonly string <AwaitExecutionContext>k__BackingField; //Field offset: 0x38

	public string AwaitExecutionContext
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public CommandFactory[] Constructors
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public string ExecutionContext
	{
		[CompilerGenerated]
		 get { } //Length: 76
	}

	public CommandItemInfo(CommandItemBase parent, string[] names, string description, string executionContext, string awaitExecutionContext, CommandFactory[] constructors) { }

	public virtual ConstructorFindResult FindConstructor(IEnumerable arguments) { }

	[CompilerGenerated]
	public string get_AwaitExecutionContext() { }

	[CompilerGenerated]
	public CommandFactory[] get_Constructors() { }

	[CompilerGenerated]
	public string get_ExecutionContext() { }

}

