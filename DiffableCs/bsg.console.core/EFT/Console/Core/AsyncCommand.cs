namespace EFT.Console.Core;

public abstract class AsyncCommand : IConsoleCommand
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public Action onComplete; //Field offset: 0x10

		public <>c__DisplayClass3_0() { }

		internal void <Execute>b__0(Task t) { }

	}

	protected ConsoleProcessor _processor; //Field offset: 0x10

	public abstract object[] ArgumentsValue
	{
		 get { } //Length: 0
	}

	protected AsyncCommand() { }

	public override void Execute(ConsoleProcessor processor, Action onComplete) { }

	public abstract Task Execute() { }

	public abstract object[] get_ArgumentsValue() { }

}

