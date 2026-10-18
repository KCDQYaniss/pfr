namespace EFT;

[Extension]
public static class CustomizationLoadOperation
{
	[CompilerGenerated]
	private struct <CreateCustomizationSolver>d__2 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public IBackendSession session; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadCustomization>d__0 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public IClientSession session; //Field offset: 0x20
		private Token <>7__wrap1; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	[AsyncStateMachine(typeof(<CreateCustomizationSolver>d__2))]
	private static Task CreateCustomizationSolver(IBackendSession session) { }

	[AsyncStateMachine(typeof(<LoadCustomization>d__0))]
	[Extension]
	public static Task LoadCustomization(IClientSession session) { }

	public static void LoadCustomization(Dictionary customizationTemplates, AvailableCustomizationsResponse availableSuites) { }

	public static void SetCustomizations(Dictionary customizationTemplates) { }

}

