namespace EFT.Console.Commands;

public class ProductionCommands
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public TaskCompletionSource executeComplete; //Field offset: 0x10

		public <>c__DisplayClass6_0() { }

		internal void <PerfTest>b__0() { }

	}

	[CompilerGenerated]
	private struct <PerfTest>d__6 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public int overall; //Field offset: 0x20
		public int every; //Field offset: 0x24
		public string label; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	public ProductionCommands() { }

	[ConsoleCommand("fps", null, null, null, new IL2CPP_TYPE_STRING[] {})]
	public static void Fps(int mode) { }

	[AsyncStateMachine(typeof(<PerfTest>d__6))]
	[ConsoleCommand("perftest", "perftest", null, null, new IL2CPP_TYPE_STRING[] {})]
	public static Task PerfTest(int overall, int every, string label) { }

	[ConsoleCommand("quit", null, null, null, new IL2CPP_TYPE_STRING[] {"q"})]
	public static void Quit() { }

	[ConsoleCommand("quit_with_code", null, null, null, new IL2CPP_TYPE_STRING[] {})]
	public static void QuitWithCode(int code) { }

	[ConsoleCommand("spec_exit", null, null, null, new IL2CPP_TYPE_STRING[] {})]
	public static void SpecExit() { }

	[ConsoleCommand("spec_next", null, null, null, new IL2CPP_TYPE_STRING[] {})]
	public static void SpecNext() { }

	[ConsoleCommand("spec_prev", null, null, null, new IL2CPP_TYPE_STRING[] {})]
	public static void SpecPrev() { }

}

