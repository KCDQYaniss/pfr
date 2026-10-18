namespace EFT;

public static class LocalizationLoader
{
	[CompilerGenerated]
	private struct <LoadLocale>d__1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string locale; //Field offset: 0x20
		public Func load; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadMainMenuLocale>d__0 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string locale; //Field offset: 0x20
		public Func load; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	[AsyncStateMachine(typeof(<LoadLocale>d__1))]
	public static Task LoadLocale(string locale, Func load) { }

	[AsyncStateMachine(typeof(<LoadMainMenuLocale>d__0))]
	public static Task LoadMainMenuLocale(string locale, Func load) { }

	private static string NormalizeLocale(string locale) { }

}

